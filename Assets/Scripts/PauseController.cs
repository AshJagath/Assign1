using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseController : MonoBehaviour {


	private bool isPaused;
	public GameObject pauseScreen;
	private float timePause;


	// Use this for initialization
	void Start () {
		//
		//set pause screen to be off when game starts	
		pauseScreen.SetActive (false);

		//pause.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (Time.timeScale);

		Time.timeScale = timePause;
		//Time.fixedDeltaTime = timePause;

			
		PauseScreen ();
		PauseTime ();
	}


	void PauseTime(){

		if (isPaused == true) {
		
			timePause = 0;

		} else {
		
			timePause = 1;
		}



	}


	void PauseScreen(){
		
		//disable and reenable the pause screen canvas in button press based on the current active value of the pausescreen gameobject
		if (Input.GetKeyDown("space")) {
			isPaused = !isPaused;
			pauseScreen.SetActive(isPaused);
			}
	}



}
