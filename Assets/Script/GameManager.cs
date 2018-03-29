using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	int currentEnemy=0;
	int initialEnemy=0;
	public Text score;

	void Start () {
		initialEnemy=GameObject.FindGameObjectsWithTag ("enemy").Length;
	}
	
	// Update is called once per frame
	void Update () {
		currentEnemy=GameObject.FindGameObjectsWithTag ("enemy").Length;
		Debug.Log (""+currentEnemy);
		if (currentEnemy == 0) {
			SceneManager.LoadScene ("LevelComplete",LoadSceneMode.Single);
		} 
		else{
			score.text = "Score: "+((initialEnemy - currentEnemy) * 100).ToString ();
		}
	}
}
