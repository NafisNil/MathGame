using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void EnterGame(){
		SceneManager.LoadScene(2, LoadSceneMode.Single);
	}

	public void Quit(){
		 Application.Quit();
	}

	public void Back(){
		SceneManager.LoadScene(1, LoadSceneMode.Single);
	}
}
