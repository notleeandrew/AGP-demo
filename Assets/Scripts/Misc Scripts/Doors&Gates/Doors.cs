using UnityEngine;
using System.Collections;

public class Doors : MonoBehaviour {

	public GameObject Door;
	public bool doorIsOpening;

	void Start(){
	}

	void Update () {
		
		if (doorIsOpening == true) {
			Door.transform.Translate (Vector3.up * Time.deltaTime * transform.position.y * 5);
			GetComponent<AudioSource> ().Play ();
		}
		if (Door.transform.position.y > 1.2f) {
			doorIsOpening = false;
		}
	}
	void OnMouseDown(){
		doorIsOpening = true;
	}
}
