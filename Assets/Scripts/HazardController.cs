using UnityEngine;
using System.Collections;

public class HazardController : MonoBehaviour {

	public float playerSizeNeeded;
	public Transform playerTransform;
	public GameObject player;
	private Vector3 playerScale;
	public float explosForce;
	public float explosRadius;
	public float damage;

	// Use this for initialization
	void Start () {
	
		playerTransform=GameObject.FindWithTag("Player").GetComponent<Transform> ();

		player = GameObject.FindWithTag ("Player");
	
	}
	
	// Update is called once per frame
	void Update () {
	
		playerScale = FindObjectOfType<PlayerController>().model.transform.localScale;

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

	
		if (collision.gameObject.tag == "Player" && playerScale.magnitude < playerSizeNeeded) {

			Detach();		

			FindObjectOfType<PlayerController>().model.transform.localScale += new Vector3(damage, damage, damage);

			audio.Play();
			}



	}



}
