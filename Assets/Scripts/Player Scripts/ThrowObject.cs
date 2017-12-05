using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObject : MonoBehaviour {

    PickupObject pickup;
    public float thrust = 100.0f;

    void Start()
    {
        pickup = GetComponent<PickupObject>();
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && pickup.carrying != null) {
            Liftable liftable = pickup.carrying;
            pickup.PutDown ();
            Rigidbody rb = liftable.GetComponent<Rigidbody>();
            rb.AddForce (transform.forward * thrust, ForceMode.Impulse);
            Debug.Log ("throw");
        }
	}
}
