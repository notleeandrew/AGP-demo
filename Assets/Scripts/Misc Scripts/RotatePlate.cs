using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlate : MonoBehaviour {

	public Behaviour Shadow;

	void OnTriggerStay (Collider other){
		if (other.gameObject.tag == "Player" && !other.isTrigger) {
			if (Input.GetKeyDown(KeyCode.E)) {
				Shadow.enabled = !Shadow.enabled;
				var cameraLook = other.GetComponentInChildren<CameraLook> ();
				cameraLook.enabled = !Shadow.enabled;
				var playerMovement = other.GetComponent<PlayerMovement> ();
				playerMovement.enabled = !Shadow.enabled;
				Cursor.lockState = Shadow.enabled? CursorLockMode.None : CursorLockMode.Locked;
				var throwing = other.GetComponent<ThrowObject> ();
				throwing.enabled = !Shadow.enabled;
				var picking = other.GetComponent<PickupObject> ();
				picking.enabled = !Shadow.enabled;
				var RigidBody = other.GetComponent<Rigidbody> ();
				RigidBody.constraints = Shadow.enabled? (RigidBody.constraints | RigidbodyConstraints.FreezeRotationY) : (RigidBody.constraints & ~RigidbodyConstraints.FreezeRotationY);
			}
		}
	}
}
