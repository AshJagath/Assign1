using UnityEngine;
using System.Collections;

public class PickupController : MonoBehaviour {


	public float playerSizeNeeded;
	public float growthRate;
	public Component playerTransform;



	// Use this for initialization
	void Start () {


		playerTransform = FindObjectOfType<PlayerController>();


	}
	
	// Update is called once per frame
	void Update () {
	
		Debug.Log (FindObjectOfType<PlayerController>().model.transform.localScale.magnitude);
	
	

	}



	void OnCollisionEnter(Collision collision){

		Debug.Log ("boop");

		if (collision.gameObject.tag == "Player" && playerTransform.transform.localScale.magnitude >= playerSizeNeeded) {
			transform.parent = GameObject.FindGameObjectWithTag ("Player").transform;

			//remove the rigidbody of the picked up item to prevent physics issues
			Destroy(rigidbody);

			//GetComponentInChildren<Collider> ().enabled = false;
			//collider.enabled = false;

			//increase the player objects scale by the pickup items growth rate
			GameObject.FindGameObjectWithTag ("Player").transform.localScale += new Vector3(growthRate, growthRate, growthRate);
		}

		//if(collision.gameObject.tag == "Player")
		//{			transform.parent = GameObject.FindGameObjectWithTag("Player").transform; } 



	}

}
