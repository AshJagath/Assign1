using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {


	public float gravity;
	public float timeLimit = 180;
	public float timeLeft;
	private bool isPaused;


	// Use this for initialization
	void Start () {


		//initialise gravity value
		Physics.gravity = new Vector3(0, -gravity, 0);

		//Load the UIOverlay
		LoadOverlay ();

		// reset the timer
		timeLeft = timeLimit;
	
		//

	}



	void LoadOverlay(){
	
		//
		Application.LoadLevelAdditive("UIOverlay");

		//
		Application.LoadLevelAdditive ("PauseScreen");

	}

	void Pause(){

		if (Input.GetKeyDown ("Space")) {

		

				}


	
	
	}

	// Update is called once per frame
	void Update () {
	
		TimeDecrease ();
	}


	void TimeDecrease(){

		timeLeft -=1*Time.deltaTime;

	}


}
