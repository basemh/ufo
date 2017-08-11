using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		playAgain ();
	}

	void playAgain () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			SceneManager.LoadScene("Main");
		}
	}
}
