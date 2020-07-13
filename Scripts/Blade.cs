using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Blade : MonoBehaviour {
    public GameObject bladeTrailPrefab;
    public float minCuttingVelocity = .01f;
    Vector2 previousPosition;

    public bool isCutting = false;




    GameObject currentBladeTrail;



    Rigidbody rb;
    Camera cam;
    // CircleCollider2D circlecollder;
    //SphereCollider sphaerecollider;
    BoxCollider BoxCollider;
    void Start () {
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
        //  circlecollder = GetComponent<CircleCollider2D>();
        //sphaerecollider = GetComponent<SphereCollider>();
        BoxCollider = GetComponent<BoxCollider>();
        gameObject.GetComponent<AudioSource>();
        source.clip = KnifeSound;
        source.playOnAwake = false;

        source.loop = false;
    }
    public void PlaySound()
    {
        source.Play();
    }
    public AudioClip KnifeSound;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    void Update () {
        if (isCutting)
        {
            UpdateCut();
        }
        if (Input.GetMouseButtonDown(0))
        {
            StartCutting();
            PlaySound();

        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopCutting();
            source.Stop();
        }
        if (isCutting)
        {
            UpdateCut();
        }
	}

    void UpdateCut()
    {
        Vector2 newPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        newPosition.y = newPosition.y -0.8f;
        rb.position = newPosition;

        //float velocity = (newPosition - previousPosition).magnitude * Time.deltaTime;

        //circlecollder.enabled = true;
        //sphaerecollider.enabled = true;
        BoxCollider.enabled = true;
        previousPosition = newPosition;
        
    }
    void StartCutting()
    {
        isCutting = true;
        currentBladeTrail =  Instantiate(bladeTrailPrefab, transform);
        previousPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        // circlecollder.enabled = true;
        //sphaerecollider.enabled = false;
        BoxCollider.enabled = false;
    }
    void StopCutting()
    {
        isCutting = false;
        currentBladeTrail.transform.SetParent(null);
        Destroy(currentBladeTrail, 2f);
        //circlecollder.enabled = false;
        BoxCollider.enabled = false;
    }
}