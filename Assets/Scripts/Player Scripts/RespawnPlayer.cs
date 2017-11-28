using UnityEngine;
using System.Collections;

public class RespawnPlayer : MonoBehaviour {

	public Vector3 RespawnPosition;


	// Use this for initialization
	void Start () 
	{
		RespawnPosition = transform.position;
		/*
		float x = PlayerPrefs.GetFloat ("PosX", transform.position.x);
		float y = PlayerPrefs.GetFloat ("PosY", transform.position.y);
		float z = PlayerPrefs.GetFloat ("PosZ", transform.position.z);
		
		//Get start position
		RespawnPosition = new Vector3(x, y, z);

		Respawn ();
	*/
}

	public void Respawn()
	{
		transform.position = RespawnPosition;
	}

	void OnTriggerEnter(Collider cool){
		if (cool.gameObject.tag == "Death") {
			Respawn ();
		}
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.P)) 
			Respawn ();

	}
	// attach to the player
}