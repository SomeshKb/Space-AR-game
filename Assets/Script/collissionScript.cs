using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class collissionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{

		GameObject explosion = Instantiate (Resources.Load ("FlareMobile", typeof (GameObject))) as GameObject;
		explosion.transform.position = transform.position;
		Destroy(col.gameObject);
		Destroy (gameObject);

	}
}
