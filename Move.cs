using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	public Vector3 forward = new Vector3 (0f, 0f, 1f);
	public Vector3 right = new Vector3 (1f, 0f, 0f);
	public KeyCode fwdKey = KeyCode.W;
	public KeyCode bckKey = KeyCode.S;
	public KeyCode rghKey = KeyCode.D;
	public KeyCode lftKey = KeyCode.A;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (fwdKey)) {
			transform.Translate (forward); 
		}
		if (Input.GetKey (bckKey)) {
			transform.Translate (-forward);
		}
		if (Input.GetKey (rghKey)) {
			transform.Translate (right); 
		}
		if (Input.GetKey (lftKey)) {
			transform.Translate (-right);
		}
	}
}
