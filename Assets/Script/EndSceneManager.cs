using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndSceneManager : MonoBehaviour {
	public Button exit;
	public Button restart;
	// Use this for initialization
	void Start () {
		exit.onClick.AddListener (OnExitDown);
		restart.onClick.AddListener (OnRestartDown);
	}
	void OnExitDown(){
		Application.Quit ();
	}
	void OnRestartDown(){
		SceneManager.LoadScene ("Level1",LoadSceneMode.Single);

	}
}
