using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipAI : MonoBehaviour {

	public Transform target;
	Vector3 acceleation;
	Vector3 velocity;
	public float maxSpeed;
	float targetSpeed;
	Rigidbody rb;
	public Rigidbody projectile;
	public Transform instantPoint;
	public float fireRate=0.5f;
	public float nextFire=0.0f;
	float distanceEnemy=40;
	bool moveTowardsPlayer=true;


	void Start () {

		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if(target!=null){
			Vector3 forces = moveTowardsTarget (target.position);
			acceleation = forces;
			velocity += 2 * acceleation * Time.deltaTime;

			if (velocity.magnitude > maxSpeed) {
				velocity = velocity.normalized * maxSpeed;
			}

			rb.velocity = velocity;

			Quaternion desiredRotation = Quaternion.LookRotation (velocity);
			transform.rotation = Quaternion.Slerp (transform.rotation, desiredRotation, Time.deltaTime * 3);
		}




	}

	Vector3 moveTowardsTarget(Vector3 target){
	
		Vector3 distance = target - transform.position;
		if (distance.magnitude < 70) {
			Rigidbody clone;
			if(Time.time>nextFire&&moveTowardsPlayer==true){
				nextFire = fireRate + Time.time;
				clone = Instantiate(projectile, instantPoint.position, transform.rotation) as Rigidbody;
				clone.velocity = transform.TransformDirection(Vector3.forward * 30);
			}
		}
		if (distance.magnitude < distanceEnemy) {
			distanceEnemy = 100;
			moveTowardsPlayer = false;
			return distance.normalized * -maxSpeed;
					} else {
			distanceEnemy = 40;
			moveTowardsPlayer = true;
			return distance.normalized * maxSpeed;
		}
		
	}


	void OnTriggerEnter(Collider col)
	{
		GameObject explosion = Instantiate (Resources.Load ("FlareMobile", typeof (GameObject))) as GameObject;
		explosion.transform.position = transform.position;
		Destroy(col.gameObject);
	}

}
