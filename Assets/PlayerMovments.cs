using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovments : MonoBehaviour {

	float maxSpeed = 5f;
	float rotSpedd = 180f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//Rotate ship
		//Grap rotation Quaternion
		Quaternion rot = transform.rotation;
		//Grap the Z eulerAngle 
		float z = rot.eulerAngles.z;
		//Change the Z angle based on input
		z -= Input.GetAxis("Horizontal") * rotSpedd * Time.deltaTime;
		//Recreate the quaternion 
		rot = Quaternion.Euler(0, 0, z);
		//Feed the quaternion into our rotation 
		transform.rotation = rot;
		
		//Move ship 
		Vector3 pos = transform.position;
		pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
		transform.position = pos;
		
		
	}
}
