using UnityEngine;
using System.Collections;

public class GoHomeGame : MonoBehaviour {

	private int numberOfSteps = 0;
	private float metersFromHome = 0.0f;

	// Use this for initialization
	void Start () {
		PrintWelcomeMessage ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.DownArrow)) {
			UpdateStatus ();
		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			metersFromHome++;
			UpdateStatus ();
		} else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			metersFromHome--;
			UpdateStatus ();
		}
	}

	void PrintWelcomeMessage() {
		print ("Welcome to Go Home!\n");
		print("A game where you need to find your way home.\n");
	}

	void UpdateStatus() {
		numberOfSteps++;
		print ("After " + numberOfSteps + " steps you are " + metersFromHome + " meters away from home.\n");
	}
}
