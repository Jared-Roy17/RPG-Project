using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w")) {
			transform.Translate (Vector3.forward);
			Debug.Log ("Pressing W key");
		}
		if (Input.GetButtonDown("Testing")) {
			Debug.Log (Input.GetAxis ("Testing"));
			Debug.Log ("Pressing Testing key");
		}
		if (Input.GetKey("a")) {
			Debug.Log ("Pressing A key");
		}
		if(Input.GetMouseButton(1)){
			Debug.Log ("Mouse Button Right");
		}
		if(Input.GetMouseButton(0)){
			Debug.Log ("Mouse Button left");
		}
	}
}
