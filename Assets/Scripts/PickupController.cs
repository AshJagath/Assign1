using UnityEngine;
using System.Collections;

public class PickupController : MonoBehaviour {


	public float playerSizeNeeded;
	public float GrowthSize;



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

			//
			GameObject.FindGameObjectWithTag ("Player").transform.localScale += new Vector3(GrowthSize, GrowthSize, GrowthSize);
		}

		//if(collision.gameObject.tag == "Player")
		//{			transform.parent = GameObject.FindGameObjectWithTag("Player").transform; } 



	}

}
