﻿using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public float playerSize;




	// Use this for initialization
	void Start () {

		//initialise gravity value
		Physics.gravity = new Vector3(0, -25, 0);

		//Load the UIOverlay
		LoadOverlay ();
	}


	void LoadOverlay(){
	
		Application.LoadLevelAdditive("UIOverlay");
	
	}

	// Update is called once per frame
	void Update () {
	
	}
}
