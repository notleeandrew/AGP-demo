using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liftable : MonoBehaviour {

	public Rigidbody rb;
	public float thrust;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		rb = GetComponent<Rigidbody> ();
	}

	public void PickingUp(Transform guide){
		GetComponent<Rigidbody> ().useGravity = false;
		GetComponent<Rigidbody> ().isKinematic = true;
		transform.position = guide.position;
		transform.rotation = guide.rotation;
		transform.parent = guide;
	}

	public void PutDown(){
		GetComponent<Rigidbody> ().useGravity = true;
		GetComponent<Rigidbody> ().isKinematic = false;
		transform.parent = null;
	}

	public void throwing(){
		if (transform.parent != null) {
			GetComponent<Rigidbody> ().useGravity = true;
			GetComponent<Rigidbody> ().isKinematic = false;
			transform.parent = null;
			rb.AddForce (transform.forward * thrust, ForceMode.Impulse);
			print ("throw");
		}
	}

	public void shadowZone(Transform shadowPosition){
		transform.parent = null;
		GetComponent<Rigidbody> ().useGravity = false;
		//GetComponent<Rigidbody> ().isKinematic = true;
		transform.position = shadowPosition.position;
		transform.parent = shadowPosition;
	}
}
