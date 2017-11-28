using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {

	public float openAngle = 90.0f;
	public float speed = 90.0f; // in degrees per second

	void Start (){
		StartCoroutine (Open ());
	}

	IEnumerator Open() {
		for (float angle = 0.0f; angle < openAngle; angle += Time.deltaTime * speed) {
			transform.rotation = Quaternion.Euler (0.0f, angle, 0.0f);
			yield return null;
		}
	}
}
