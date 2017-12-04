using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMirror : MonoBehaviour {

	public float yRotation = 20f;

	void OnTriggerStay (Collider col){
		if (col.gameObject.tag == "Player") {
            if (Input.GetKey(KeyCode.E)) {
                transform.Rotate(Vector3.up * yRotation * Time.deltaTime);
                //transform.eulerAngles = new Vector3 (0, transform.eulerAngles.y + yRotation, 0);
                print("I'm turning");
            }
            if (Input.GetKey(KeyCode.Q))
            {
                transform.Rotate(Vector3.down * yRotation * Time.deltaTime);
                //transform.eulerAngles = new Vector3 (0, transform.eulerAngles.y + yRotation, 0);
                print("I'm turning");
            }
        }
	}
}
