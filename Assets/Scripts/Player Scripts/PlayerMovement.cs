using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 10f;
	public float jumpSpeed;

	public bool canJump;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);

		if (Input.GetButtonDown("Jump") && canJump) {
			rb.velocity = new Vector3 (0, jumpSpeed, 0);
		}

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
	}

	void OnCollisionEnter(Collision up){
		if (up.gameObject.CompareTag("Floor")) {
			canJump = true;
		}
	}

	void OnCollisionExit(Collision up){
		if (up.gameObject.CompareTag("Floor")) {
			canJump = false;
		}
	}
}
