using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour {

	public Transform guide;

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay(Collider pick){
		Liftable liftable = pick.GetComponent<Liftable> ();
		if (liftable != null) {
			liftable.enabled = true;
			if (Input.GetMouseButtonDown(0)) {
				liftable.PickingUp (guide);
			}
			if (Input.GetMouseButtonUp(0)) {
				liftable.PutDown ();
			}
		}
	}
}
