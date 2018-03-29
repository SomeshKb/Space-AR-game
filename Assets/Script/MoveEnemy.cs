using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour {


	public Transform target;
	public float speed=1f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Rigidbody clone;
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.position, step);
	}
		

}
