using UnityEngine;
using System.Collections;

public class PickupController : MonoBehaviour {


	public float playerSizeNeeded;
	public float growthRate;
	private Vector3 playerScale;



	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {

		playerScale = FindObjectOfType<PlayerController>().model.transform.localScale;

	
		Debug.Log (playerScale.x);

	}



	void OnCollisionEnter(Collision collision){

		Debug.Log ("boop");

			//for the oject to stick it needs to collide with the player and the player must be a of a certain size
		if (collision.gameObject.tag == "Player" && playerScale.x >= playerSizeNeeded) {

			//transform teh pickup object to be a cbild of teh player which makes it 'stick' on contact
			transform.parent = GameObject.FindGameObjectWithTag ("Player").transform;

			//remove the rigidbody of the picked up item to prevent physics issues
			Destroy(rigidbody);

			//GetComponentInChildren<Collider> ().enabled = false;
			//collider.enabled = false;

			//increase the player objects scale by the pickup items growth rate
			FindObjectOfType<PlayerController>().model.transform.localScale += new Vector3(growthRate, growthRate, growthRate);
		
		}

		//if(collision.gameObject.tag == "Player")
		//{			transform.parent = GameObject.FindGameObjectWithTag("Player").transform; } 



	}

}
