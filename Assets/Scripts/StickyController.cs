using UnityEngine;
using System.Collections;

public class StickyController : MonoBehaviour {

	public int size;


	// Use this for initialization
	void Start () {
	
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void onCollisionEnter(Collision collider){


		if(gameObject.tag == "Sticky")
		{transform.parent = transform; } 



	}

}
