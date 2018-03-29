using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInstantiator : MonoBehaviour {
	public Rigidbody projectile;
	bool canShoot=true;
	public Transform instantPoint;

	public float fireRate=0.5f;
	public float nextFire=0.0f;


	// Update is called once per frame
	void FixedUpdate () {
		Rigidbody clone;
		if(Time.time>nextFire){
			nextFire = fireRate + nextFire;
			clone = Instantiate(projectile, instantPoint.position, transform.rotation) as Rigidbody;
			clone.velocity = transform.TransformDirection(Vector3.forward * 20);
		}
	}
		
}
