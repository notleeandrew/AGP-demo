using UnityEngine;
using System.Collections;

public class EnemyAttract : MonoBehaviour {

	public UnityEngine.AI.NavMeshAgent ThisAgent = null;
	public Transform Player = null;
	public float SeeingDistance = 10f;


	void Start(){
		ThisAgent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}

	void Update(){
		float PlayerDistance = Vector3.Distance (Player.position, transform.position);
		if (PlayerDistance <= SeeingDistance) {
			ThisAgent.SetDestination (Player.position);
			GetComponent<AudioSource> ().Play ();
		}
	}
	// you first need to set the platform to static, then bake a nave mesh, then attach a navmeshagent to the enemy
}
