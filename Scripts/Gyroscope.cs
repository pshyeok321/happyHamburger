using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyroscope : MonoBehaviour {
    Vector3 gyroscope_rotation;
	// Use this for initialization
	void Awake() {
        Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
        gyroscope_rotation.x += Input.gyro.rotationRateUnbiased.x;
        gyroscope_rotation.y += Input.gyro.rotationRateUnbiased.z;
    }
}
