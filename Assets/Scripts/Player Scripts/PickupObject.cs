using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour {

	public Transform guide;
    internal Liftable carrying = null;

    List<Liftable> colliding = new List<Liftable>(); // the list of things we're currently colliding with

	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && colliding.Count > 0) {
            carrying = colliding[0];
            carrying.Attach (guide);
        }
        else if (Input.GetMouseButtonUp(0) && carrying != null) {
            PutDown ();
        }
	}

    public void PutDown()
    {
        if (carrying != null)
        {
            carrying.PutDown();
            carrying = null;
        }
    }

    void OnTriggerEnter(Collider pick){
        Liftable liftable = pick.GetComponent<Liftable>();
        if (liftable != null && !colliding.Contains(liftable))
        {
            colliding.Add(liftable);
        }
    }

    void OnTriggerExit(Collider pick){
        Liftable liftable = pick.GetComponent<Liftable>();
        if (liftable != null && colliding.Contains(liftable))
        {
            colliding.Remove(liftable);
        }
    }
}
