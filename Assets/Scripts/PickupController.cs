using UnityEngine;
using System.Collections;

public class PickupController : MonoBehaviour {

	public int size;



	// Use this for initialization
	void Start () {

	

	}
	
	// Update is called once per frame
	void Update () {
	

	}



	void OnCollisionEnter(Collision collision){

		Debug.Log ("boop");
		if (collision.gameObject.tag == "Player") {
			transform.parent = GameObject.FindGameObjectWithTag ("Player").transform;
			GetComponentInChildren<Collider> ().enabled = false;
			//collider.enabled = false;
		}

		//if(collision.gameObject.tag == "Player")
		//{			transform.parent = GameObject.FindGameObjectWithTag("Player").transform; } 



	}

}
