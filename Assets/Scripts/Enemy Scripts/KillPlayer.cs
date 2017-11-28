using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

	private GameObject player;

	void Start(){

		player = GameObject.FindGameObjectWithTag ("Player");

	}

	void Update(){

	}
	void OnTriggerEnter(Collider target){
		if (target.gameObject.tag == "Player") {
			player.GetComponent<RespawnPlayer> ().Respawn();
	}
		//attach another gameobject to the enemy then attach another box collider alongside this script and set it to isTrigger
}
}