using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PressurePlates : MonoBehaviour {

	public GameObject gate;
	public float distance = 5f;
	private float endPos;
	private float startPos;
	public bool colliding;

	void Start(){
		startPos = gate.transform.position.y;
		endPos = startPos + distance;
		colliding = false;
	}

	void OnTriggerEnter(Collider lift){
		if (lift.CompareTag ("liftableObject")) {
			colliding = true;
		}
	}
	void OnTriggerExit(Collider lift){
		if (lift.CompareTag ("liftableObject")) {
			colliding = false;
		}
	}

	void Update() {
		if (colliding == true && gate.transform.position.y < endPos) {
			gate.transform.Translate (Vector3.up * Time.deltaTime * transform.position.y * distance);
		} 
		if (colliding == false && gate.transform.position.y > startPos) {
			gate.transform.Translate (Vector3.down * Time.deltaTime * transform.position.y * distance);
		}
	}
}
//make sure player is tagGed (Player)
//make sure the moveable object is tagged something appropriate and you can change the box to anything
//apply this to the pressure plate