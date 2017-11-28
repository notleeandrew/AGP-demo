using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowObjectZone : MonoBehaviour {

	public Transform shadowPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider pick){
		Liftable liftable = pick.GetComponent<Liftable> ();
		if (liftable != null) {
			liftable.shadowZone (shadowPosition);
		}
	}
}
