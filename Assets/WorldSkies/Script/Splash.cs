using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour {

	public static int sceneNumber ;
	// Use this for initialization
	void Start () {
		if(sceneNumber == 0)
			StartCoroutine(ToGame());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator ToGame(){
		yield return new WaitForSeconds(3);
		sceneNumber = 1;
		SceneManager.LoadScene(1, LoadSceneMode.Single);
	}
}
