using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMirror : MonoBehaviour {

	public float yRotation = 20f;

	void OnTriggerStay (Collider col){
		if (col.gameObject.tag == "Player") {
			if (Input.GetKeyDown(KeyCode.E)) {
				transform.eulerAngles = new Vector3 (0, transform.eulerAngles.y + yRotation, 0);
				print ("I'm turning");
			}
		}
	}
}
