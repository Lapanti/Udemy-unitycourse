using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {
	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			guess = NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			guess = NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
			StartGame ();
		}
	}

	void StartGame () {
		max = 1000;
		min = 1;
		guess = Random.Range (min, max);
		print ("====================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		print ("Is the number higher or lower than " + guess + "?");
		max += 1;
	}

	int NextGuess () {
		int temp = Random.Range (min, max);
		print ("Is the number higher or lower than " + temp + "?");
		return temp;
	}
}
