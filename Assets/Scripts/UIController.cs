using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
		
	public GameController gameController;

	public float currentSize;

	public float time;
	public float size;
	public Text uITimer;
	public Text uISize;
	

	// Use this for initialization
	void Start () {

		//set gamecontroller so that UI controller can call variables
		gameController = GameObject.FindObjectOfType<GameController> ();

		//get time value from gamecontroller
		time = gameController.timeLeft;
	

	}
	
	// Update is called once per frame
	void Update () {
		//find the players current model scale magnitude
		currentSize = FindObjectOfType<PlayerController>().model.transform.localScale.x;

		//update the ui text with the timer value
		uITimer.text = time + "s";
		//get current time and round to second
		time = Mathf.Round(gameController.timeLeft * 100f) / 100f;


		//update the ui text with the players current size
		uISize.text = "Current Size " + (size);
		//round the current side to 2 decimal places for use in the UI
		size = Mathf.Round(currentSize * 10000f) / 10000;




	}
}
