using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public Canvas MainCanvas;
	//public Canvas OptionsCanvas;

	void Awake(){
	//	OptionsCanvas.enabled = false;
	}

/*	public void OptionsOn(){
		OptionsCanvas.enabled = true;
		MainCanvas.enabled = false;
	}

	public void ReturnOn(){
		OptionsCanvas.enabled = false;
		MainCanvas.enabled = true;
	}
*/
	public void LoadOn(){
		SceneManager.LoadScene (1);
	}

	public void Menu(){
		SceneManager.LoadScene ("MainMenuScreen");
	}

	public void PlayGame(){
		SceneManager.LoadScene (2);
	}

	public void ExitGame (){

		Application.Quit();

	}
}
