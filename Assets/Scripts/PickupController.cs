using UnityEngine;
using System.Collections;

public class PickupController : MonoBehaviour {


	public float playerSizeNeeded;
	public float growthRate;
	private Vector3 playerScale;



	// Use this for initialization
	void Start () {


		playerScale = FindObjectOfType<PlayerController>().model.transform.localScale;


	}
	
	// Update is called once per frame
	void Update () {
		playerScale = FindObjectOfType<PlayerController>().model.transform.localScale;

	
		Debug.Log (playerScale.magnitude);
	
	

	}



	void OnCollisionEnter(Collision collision){

		Debug.Log ("boop");

		if (collision.gameObject.tag == "Player" && playerScale.magnitude >= playerSizeNeeded) {
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
