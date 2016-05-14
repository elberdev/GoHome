using UnityEngine;
using System.Collections;

public class GoHomeGame : MonoBehaviour
{

	private int numberOfSteps = 0;
	private Vector2 homeLocation = new Vector2 (2.0f, 3.0f);
	private Vector2 playerLocation = new Vector2 (5.0f, 1.0f);
	private bool gameOver = false;

	// Use this for initialization
	void Start ()
	{
		PrintWelcomeMessage ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (gameOver) {
			return;
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			// add one unit up
			playerLocation += Vector2.up;
			UpdateStatus ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			// add one unit down, you get the idea
			playerLocation += Vector2.down;
			UpdateStatus ();
		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			playerLocation += Vector2.right;
			UpdateStatus ();
		} else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			playerLocation += Vector2.left;
			UpdateStatus ();
		}
	}

	void PrintWelcomeMessage ()
	{
		print ("Welcome to Go Home!\n");
		print ("A game where you need to find your way home.\n");
	}

	void UpdateStatus ()
	{
		Vector2 distance = homeLocation - playerLocation;
		bool gameOver = distance.magnitude == 0;
		numberOfSteps++;
		if (gameOver) {
			print ("You win! You made it back to your stinky home in " + numberOfSteps + "!\n");
		} else {
			print ("After " + numberOfSteps + " steps you are " + distance.magnitude + " meters away from home.\n");
		}
	}
}
