using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {


	public float gravity;
	public float timeLimit;
	public float timeLeft;




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

	// Update is called once per frame
	void Update () {
		
		TimeDecrease ();
	}



	void LoadOverlay(){
	
		// LOAD THE HUD
		Application.LoadLevelAdditive("UIOverlay");

		//LOAD UP PAUSE SCREEN
		Application.LoadLevelAdditive ("PauseScreen");

		//


	}

	



	void TimeDecrease(){
		// decrase remaining time my 1 every actual second
		timeLeft -=1*Time.deltaTime;

	}


}
