using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class NonFoodControl : MonoBehaviour {
    private Material m;
    public UIManager uIManager;

    public ParticleSystem explosion;

    public AudioClip sound;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }


    public BoxCollider bx;
    public MeshRenderer mesh;
    // Use this for initialization
    void Start() {
        m = gameObject.GetComponent<MeshRenderer>().material;
        bx = gameObject.GetComponent<BoxCollider>();
        mesh = gameObject.GetComponent<MeshRenderer>();
        source.clip = sound;
        source.playOnAwake = false;
        source.loop = false;
    }

    // Update is called once per frame
    void Update() {
          Destroy(gameObject, 10f);
    }

    private void OnCollisionEnter(Collision col)
    {
        //칼썰리고폭발한다음1초뒤씬이동
        if (col.gameObject.tag == "Player")
        {
            mesh.enabled = false;
            bx.enabled = false;
           Instantiate(explosion, transform.position, transform.rotation);
            StartCoroutine("Ex");
            source.Play();
        }
        if (col.gameObject.tag == "Floor")
        {
            mesh.enabled = false;
            bx.enabled = false;
            StartCoroutine("FadeOut");
            
        }
        //칼썰리고폭발한다음1초뒤씬이동
         if(col.gameObject.tag=="Blade")
        {
            mesh.enabled = false;
            bx.enabled = false;
            Instantiate(explosion, transform.position, transform.rotation);
            StartCoroutine("Ex");
            source.Play();
        }
    }
    IEnumerator Ex()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("S4");
    }

    IEnumerator FadeOut()
    {
        while (m.color.a > 0)
        {
           Color newColor = m.color;
            newColor.a -= Time.deltaTime * 1f;
           m.color = newColor;
            gameObject.GetComponent<MeshRenderer>().material = m;
            yield return 0;

            
        }
   }
}

