using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public Text highScoreText;
	// Use this for initialization
	void Start () {
		highScoreText.text = "HighScore : "+PlayerPrefs.GetInt("HighScore");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
