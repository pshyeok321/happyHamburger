using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//참고 https://www.youtube.com/watch?v=3g5_8sE18tQ
public class FoodControl2 : MonoBehaviour
{
    private Material m;
    private MeshRenderer mesh;
    Rigidbody rb;
    [SerializeField]
    private float speed;
    public EightH1 player;
    //public SphereCollider sc;
    public BoxCollider bc;
    public GameObject fruitSlice;
    // Use this for initialization
    public AudioClip sound;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    void Start()
    {
        speed = Random.Range(0.01f, 0.02f);
        m = gameObject.GetComponent<MeshRenderer>().material;
        mesh = gameObject.GetComponent<MeshRenderer>();
        bc = gameObject.GetComponent<BoxCollider>();
        rb = gameObject.GetComponent<Rigidbody>();
        source.clip = sound;
        source.playOnAwake = false;
        source.loop = false;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Floor")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Blade")
        {
            mesh.enabled = false;
            bc.enabled = false;
            source.Play();
            speed = 0;
            //rb.useGravity = false;
            //sc.enabled = false;
            Vector3 direction = (col.transform.position - transform.position).normalized;
            //     Quaternion rotation = Quaternion.LookRotation(direction);            
            Instantiate(fruitSlice, transform.position, transform.rotation);
            Destroy(gameObject, 1f);            

            //enabled = false;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        //if (collision.tag == "Blade")
        //{
        //    Vector3 direction = (collision.transform.position - transform.position).normalized;
        //    Quaternion rotation = Quaternion.LookRotation(direction);
        //    Destroy(collision.gameObject);
        //}
    }
}