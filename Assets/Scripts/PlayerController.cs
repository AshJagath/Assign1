using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 100;
	public float turnSpeed = 10;



	// Use this for initialization
	void Start () {
		Physics.gravity = new Vector3(0, -1.0F, 0);
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	//void onCollisionEnter(Collision collider){
		
		
		//if(gameObject.tag == "Sticky")
		//{transform.parent = transform; } 
		
		
		
	//}

	void FixedUpdate(){

		//player input, magnitude controlled with speed varioable
		float vInput = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
		float hInput = Input.GetAxis ("Horizontal")* speed * Time.deltaTime;

		// apply force to the player based on input and speed variable
		rigidbody.AddForce (Vector3.forward * vInput, ForceMode.Force);
		rigidbody.AddForce (Vector3.right * hInput, ForceMode.Force);

	
		//add torque gives a nice rotation vs input feel however is not moving the player effectively
		//rigidbody.AddTorque (Vector3.right * vInput, ForceMode.Force);
		//rigidbody.AddTorque(Vector3.forward * -hInput , ForceMode.Force);
	
	}


}
