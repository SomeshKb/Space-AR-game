using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class collissionScript : MonoBehaviour {

	
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
