using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public float followDistance;
	public float heightDistance;
	public Transform target;

	//public Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		// set camaera to follow the target at a set distance
		transform.position = new Vector3(target.position.x, target.position.y + heightDistance, target.position.z - followDistance);
	
		transform.LookAt (target);
	}

	void FixedUpdate(){

		
	


	}

}
