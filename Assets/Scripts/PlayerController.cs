using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 100;
	public float turnSpeed = 10;
	public int BallSize;
	//private GameObject Player;

	// Use this for initialization
	void Start () {

		//Player = GameObject.FindGameObjectWithTag ("Player");

	}
	
	// Update is called once per frame
	void Update () {
	


	}

	void OnCollisionEnter(Collision collision){
		
		Debug.Log ("bump");
		
		//if (collision.gameObject.tag == "PickUp" && BallSize >= ) {

			//collider.enabled = false;
		//}
		
		//if(collision.gameObject.tag == "Player")
		//{transform.parent = GameObject.FindGameObjectWithTag("Player").transform; } 
		
		
		
	//}

	}

	void FixedUpdate(){

		//player input, magnitude controlled with speed varioable
		float vInput = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
		float hInput = Input.GetAxis ("Horizontal")* speed * Time.deltaTime;

		// apply force to the player based on input and speed variable
		rigidbody.AddForce (Vector3.forward * vInput, ForceMode.Force);
		rigidbody.AddForce (Vector3.right * hInput, ForceMode.Force);

	
		//add torque gives a nice rotation vs input feel however is not moving the player effectively
		rigidbody.AddTorque (Vector3.right * vInput, ForceMode.Force);
		rigidbody.AddTorque(Vector3.forward * -hInput , ForceMode.Force);
	
	}

	 public void GrowPlayer(){

		Debug.Log ("GrowPlayer");
			

	}





}
