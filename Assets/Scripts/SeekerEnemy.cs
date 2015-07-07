using UnityEngine;
using System.Collections;

public class SeekerEnemy : MonoBehaviour {

	public Transform target;
	public float speed = 5f;
	public float chaseDistance = 3f;
	private float distanceToplayer;
	private Transform playerPosition;
	private 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		playerPosition = FindObjectOfType<PlayerController> ().model.transform;

		//distanceToplayer = Vector3.Distance (transform.position, playerPosition);
	}


	void FixedUpdate(){

		transform.LookAt(target);
		rigidbody.MovePosition(transform.position + transform.forward *  speed *Time.deltaTime);

	}

}
