using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		
	}


	// Update is called once per frame
	void OnTriggerEnter(Collider col)
	{
		Debug.Log (""+col.gameObject.name);
		Destroy (col.gameObject);
	}
}
