using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotor : MonoBehaviour {
	public Vector3 rotationDirection = new Vector3 (0f, 0f,0f);
	public KeyCode rotationKey =KeyCode.E;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update (){
		if (Input.GetKey (rotationKey)) {
			transform.Rotate (rotationDirection);
		} else {
			transform.Rotate (-rotationDirection);
		}
	}
}
