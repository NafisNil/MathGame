using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

	Image TimerBar;
	public float maxTime = 30f;
	float timeLeft;
	public GameObject timesUp;
	public Button yes, no;
	// Use this for initialization
	void Start () {
		timesUp.SetActive(false);
		TimerBar = GetComponent<Image>();
		timeLeft = maxTime;
	}
	
	// Update is called once per frame
	void Update () {
		if(timeLeft > 0){
			timeLeft -= Time.deltaTime;
			TimerBar.fillAmount = timeLeft/maxTime;
		}else{
			timesUp.SetActive(true);
			Time.timeScale = 0;
			yes.interactable = false;
			no.interactable = false;
		}
	}
}
