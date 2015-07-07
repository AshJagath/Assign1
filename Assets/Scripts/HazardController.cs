using UnityEngine;
using System.Collections;

public class HazardController : MonoBehaviour {

	public float playerSizeNeeded;
	public Transform playerTransform;
	public GameObject player;
	public float explosForce;
	public float explosRadius;


	// Use this for initialization
	void Start () {
	
		playerTransform=GameObject.FindWithTag("Player").GetComponent<Transform> ();

		player = GameObject.FindWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
	


	}

	void Detach(){

		PickupController[] attached = player.transform.GetComponentsInChildren<PickupController>();
		foreach(var pickup in attached){

			pickup.gameObject.transform.parent=null;
			pickup.gameObject.AddComponent<Rigidbody>();
			pickup.gameObject.rigidbody.AddExplosionForce(explosForce,playerTransform.position,explosRadius);
		}

		//player.transform.DetachChildren();

			
	}

	void OnCollisionEnter(Collision collision){

	
		if (collision.gameObject.tag == "Player" && playerTransform.transform.localScale.magnitude < playerSizeNeeded) {
			Detach();		
					
		
		}



	}



}
