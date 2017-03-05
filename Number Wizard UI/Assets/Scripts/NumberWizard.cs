using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour {
	public Text header;
	private int min = 1;
	private int max = 1000;
	private int guess;
	private int maxGuess = 5;
	private int spent = 0;

	// Use this for initialization
	void Start () {
		NextGuess ();
		max += 1;
	}
	
	// Update is called once per frame
	void Update () {
		header.text = "Is your number " + guess + "?";
	}

	public void Higher () {
		min = guess;
		NextGuess ();
	}

	public void Lower () {
		max = guess;
		NextGuess ();
	}

	public void Correct () {
		SceneManager.LoadScene ("Lose");
	}

	void NextGuess () {
		guess = Random.Range(min, max);
		spent += 1;
		if (spent >= maxGuess) {
			SceneManager.LoadScene ("Win");
		}
	}
}
