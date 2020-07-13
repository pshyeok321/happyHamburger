using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpeed : MonoBehaviour {
    [SerializeField]
    private float speed;

    // Use this for initialization
    void Start () {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
