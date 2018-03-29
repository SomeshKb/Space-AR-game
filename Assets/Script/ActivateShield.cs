using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ActivateShield : MonoBehaviour {
	public Button shieldButton;
	public GameObject myobject;
	public Text shieldText;


	// Use this for initialization
	void Start () {
		shieldButton.onClick.AddListener (OnButtonDown);

	}
	
	void OnButtonDown () {
		myobject.SetActive(true);
		shieldText.text="Shield Activated";
		StartCoroutine ("Move");


	}


	IEnumerator Move() {
		yield return new WaitForSeconds (10f);
		myobject.SetActive (false);
		shieldText.text="";

	}
}
