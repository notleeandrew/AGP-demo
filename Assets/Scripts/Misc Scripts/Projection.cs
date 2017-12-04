using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projection : MonoBehaviour {

	public Light SpotLight;
	public enum Type
	{
		Light,
		Shadow
	}

	public Type type = Type.Light;

	public float raycastlength = 20f;

	// Use this for initialization
	void Start () {
		SpotLight = gameObject.GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;

		Debug.DrawRay (transform.position, transform.forward * raycastlength, Color.green);

		if (Physics.Raycast(transform.position, transform.forward, out hit)) {
			hit.collider.SendMessageUpwards ("Receive", type, SendMessageOptions.DontRequireReceiver);
		}
	}
}
