using UnityEngine;
using System.Collections;

public class PressurePlates : MonoBehaviour {

	public GameObject gate;

	void Start(){

	}

	void OnTriggerEnter(Collider lift){
		/*if (lift.CompareTag ("Player")) {
			gate.transform.Translate (Vector3.up * Time.deltaTime * transform.position.y * 5);
		}*/
		if (lift.CompareTag ("liftableObject")) {
			gate.transform.Translate (Vector3.up * Time.deltaTime * transform.position.y * 5);

		}
	}
	void OnTriggerExit(Collider lift){
		/*if (lift.CompareTag ("Player")) {
			gate.transform.Translate (Vector3.down * Time.deltaTime * transform.position.y * 5);
		}*/
		if (lift.CompareTag ("liftableObject")) {
			gate.transform.Translate (Vector3.down * Time.deltaTime * transform.position.y * 5);
		}
	}
	//make sure player is tagGed (Player)
	//make sure the moveable object is tagged something appropriate and you can change the box to anything
	//apply this to the pressure plate
	//put the platform you want to disappear and reappear in the gate variable in the inspector
}
