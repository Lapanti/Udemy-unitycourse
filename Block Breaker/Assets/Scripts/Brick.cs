﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
	public int maxHits;
	
	private int timesHit;
	private LevelManager levelManager;

	// Use this for initialization
	void Start () {
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}

	void OnCollisionEnter2D (Collision2D collision) {
		timesHit ++;
		SimulateWin();
	}

	// TODO Remove this method
	void SimulateWin () {
		levelManager.LoadNextLevel ();
	}
}
