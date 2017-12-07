using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liftable : MonoBehaviour {

	public Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Attach(Transform guide){
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

    public bool IsAttached()
    {
        return transform.parent != null;
    }

	public void shadowZone(Transform shadowPosition){
		transform.parent = null;
		GetComponent<Rigidbody> ().useGravity = false;
		//GetComponent<Rigidbody> ().isKinematic = true;
		transform.position = shadowPosition.position;
		transform.parent = shadowPosition;
	}
}
