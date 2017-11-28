using UnityEngine;
using System.Collections;

public class Checkpoints : MonoBehaviour {

	void OnTriggerEnter(Collider Col){
		
		if (!Col.CompareTag ("Player"))
			return;

		RespawnPlayer PC = Col.GetComponent<RespawnPlayer> ();
		PC.RespawnPosition = Col.gameObject.transform.position;

		//Save Position
		/*
		PlayerPrefs.SetFloat("PosX", transform.position.x);
		PlayerPrefs.SetFloat("PosY", transform.position.y);
		PlayerPrefs.SetFloat("PosZ", transform.position.z);
		*/
		PlayerPrefs.Save ();

	}
	//attach to the empty gameobjects with box colliders acting as checkpoints
}
