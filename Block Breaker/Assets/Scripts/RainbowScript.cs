using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RainbowScript : MonoBehaviour {
	public Text text;
	public float speed;
	
	// Update is called once per frame
	void Update () {
		text.color = Color.HSVToRGB (Mathf.PingPong (Time.time * speed, 1), 1, 1);
	}
}
