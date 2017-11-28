using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class PauseGame : MonoBehaviour {

	public Transform canvas;
	public Transform Player;

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Pause ();
		}
	}
	public void Pause(){
		if (canvas.gameObject.activeInHierarchy == false) {
			canvas.gameObject.SetActive (true);
			Time.timeScale = 0;
			Player.GetComponent<PlayerMovement> ().enabled = false;
			Player.GetComponentInChildren<CameraLook> ().enabled = false;
		} else {
			canvas.gameObject.SetActive (false);
			Time.timeScale = 1;
			Player.GetComponent<PlayerMovement> ().enabled = true;
			Player.GetComponentInChildren<CameraLook> ().enabled = true;

		}
	}

	public void RestartLevel(){
		Time.timeScale = 1;
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}

	public void ExitGame(){
		SceneManager.LoadScene (0);
	}

}
