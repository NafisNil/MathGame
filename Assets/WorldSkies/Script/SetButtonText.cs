using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetButtonText : MonoBehaviour {

    string[] texts = new string[] { "+", "-", "*","/", "%" };
    string[] texts2 = new string[] { "-", "/", "+", "%", "*" };
     string  myString, myString2;
    int myString3,myString4,myString5,myString6;
    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //operator change randomly
    public void setRandom()
    {
         myString = texts[Random.Range(0, texts.Length)];
         myString2 = texts2[Random.Range(0, texts2.Length)];
        myString3 = Random.Range(0,11);
         myString4 = Random.Range(1,11);
          myString5 = Random.Range(0,11);
           myString6 = Random.Range(1,11);
        GameObject.Find("Operator1").GetComponentInChildren<Text>().text = myString;
        GameObject.Find("Operator2").GetComponentInChildren<Text>().text = myString2;
         GameObject.Find("First").GetComponentInChildren<Text>().text = myString3.ToString();
        GameObject.Find("Second").GetComponentInChildren<Text>().text = myString4.ToString();
         GameObject.Find("Third").GetComponentInChildren<Text>().text = myString5.ToString();
        GameObject.Find("Fourth").GetComponentInChildren<Text>().text = myString6.ToString();
    }
}

