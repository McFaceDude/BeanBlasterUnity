using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour {
	private Rigidbody2D _rigidBody;


	// Use this for initialization
	void Start () {
	_rigidBody = GetComponent<Rigidbody2D>();	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		Debug.Log(Input.GetAxisRaw("Horizontal"));
		Vector2 velocity  = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		_rigidBody.transform.Translate(velocity);
	}
}
