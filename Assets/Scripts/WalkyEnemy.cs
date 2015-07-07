using UnityEngine;
using System.Collections;

public class WalkyEnemy : MonoBehaviour {



	public float speed;
	public float turnAngle;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){

			transform.Translate (transform.forward * speed * Time.deltaTime);
		transform.Rotate (0, turnAngle, 0);
	}



}
