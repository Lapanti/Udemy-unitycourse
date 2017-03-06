using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkScript : MonoBehaviour {
	public Text text;
	public float speed;
	
	// Update is called once per frame
	void Update () {
		text.color = new Color(1, 1, 1, Mathf.PingPong (Time.time * speed, 1));
	}
}
