using UnityEngine;
using System.Collections;

public class PickupController : MonoBehaviour {


	public float playerSizeNeeded;
	public float growthRate;
	public Transform playerTransform;



	// Use this for initialization
	void Start () {


		playerTransform=GameObject.FindWithTag("Player").GetComponent<Transform> ();


	}
	
	// Update is called once per frame
	void Update () {
	
		Debug.Log (playerTransform.transform.localScale.magnitude);
	
	

	}



	void OnCollisionEnter(Collision collision){

		Debug.Log ("boop");

		if (collision.gameObject.tag == "Player" && playerTransform.transform.localScale.magnitude >= playerSizeNeeded) {
			transform.parent = GameObject.FindGameObjectWithTag ("Player").transform;
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
