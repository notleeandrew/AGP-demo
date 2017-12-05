using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {

	float rotSpeed = 300f;


	// Use this for initialization
	void OnMouseDrag () {
		print (enabled);
		if (enabled) {
			float rotX = Input.GetAxis ("Mouse X") * rotSpeed * Mathf.Deg2Rad;
			float rotY = Input.GetAxis ("Mouse Y") * rotSpeed * Mathf.Deg2Rad;
			print ("test");
			transform.Rotate (Vector3.up, -rotX);
			transform.Rotate (Vector3.right, -rotY);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
