using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class scenechange : MonoBehaviour {

    int currentlevel;

    private void Start()
    {
        currentlevel = SceneManager.GetActiveScene().buildIndex;
    }
     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(currentlevel + 1);
        }
    }
}
