using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour {

	public Projection.Type type = Projection.Type.Light;
	public List<Behaviour> activateObjects;
	float timeSinceHit = 0.0f;

	// Use this for initialization
	void Start () {
	}

	void Activate(bool activate) {
		foreach (Behaviour behaviour in activateObjects) {
			behaviour.enabled = activate;
		}
	}

	void Receive(Projection.Type receiveType){
		if (receiveType == type) {
			timeSinceHit = 0.0f;
			Activate (true);
		}
	}

	// Update is called once per frame
	void Update () {
		timeSinceHit += Time.deltaTime;
		if (timeSinceHit > 0.1f) {
			Activate (false);
		}
	}


}
