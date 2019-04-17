using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonText : MonoBehaviour {

     string s1,s2,s3,s4,op1,op2;
     int f1,f2,f3,f4;
    public int score = 0;
    float res1=0f, res2=0f;
   public Text text;
   public AudioSource as1,as2;
    // Use this for initialization
    void Start () {
       text.text = "Score : "+ score;
       
    }
	
	// Update is called once per frame
	public void Update () {
        
	}
   
    //operation
    public void getText()
    {
	 	s1 = GameObject.Find("First").GetComponentInChildren<Text>().text ;
        s2 = GameObject.Find("Second").GetComponentInChildren<Text>().text;
        s3 = GameObject.Find("Third").GetComponentInChildren<Text>().text;
        s4 = GameObject.Find("Fourth").GetComponentInChildren<Text>().text;
        f1 = int.Parse(s1);
        f2 = int.Parse(s2);
        f3 = int.Parse(s3);
        f4 = int.Parse(s4);
       
        op1 = GameObject.Find("Operator1").GetComponentInChildren<Text>().text;
        op2 = GameObject.Find("Operator2").GetComponentInChildren<Text>().text;
        //first pair of button
        switch (op1)
        {
            case "+":
                res1 = f1 + f2;
                //Debug.Log(res1);
                break;
            case "-":
                res1 = f1 - f2;
               // Debug.Log(res1);
                break;
            case "*":
                res1 = f1 * f2;
               // Debug.Log(res1);
                break;
            case "/":
                res1 = f1 / f2;
                //Debug.Log(res1);
                break;
            case "%":
                res1 = f1 % f2;
               // Debug.Log(res1);
                break;
            case "^":
                res1 = Mathf.Pow(f1, f2);
               // Debug.Log(res1);
                break;
            default:
                Debug.Log("Unknown");
                break;
        }

        //second pair of button
        switch (op2)
        {
            case "+":
                res2 = f3 + f4;
                //Debug.Log(res2);
                break;
            case "-":
                res2 = f3 - f4;
                //Debug.Log(res2);
                break;
            case "*":
                res2 = f3 * f4;
                //Debug.Log(res2);
                break;
            case "/":
                res2 = f3 / f4;
                //Debug.Log(res2);
                break;
            case "%":
                res2 = f3 % f4;
                //Debug.Log(res2);
                break;
            case "^":
                res2 = Mathf.Pow(f1, f2);
                //Debug.Log(res2);
                break;
            default:
                Debug.Log("Unknown");
                break;
        }

        
    }

    //positive result match
    public void matchResult()
    {
        getText();
        if( res1 == res2){
             score++;
            as1.Play();
        }else
            as2.Play();
           
        Debug.Log("score : "+score + " res1 : "+res1+" res2 : "+ res2);
        res1 =0 ;
        res2 = 0;
        if(PlayerPrefs.GetInt("HighScore") < score)
            PlayerPrefs.SetInt("HighScore", score);

       text.text = "Score : "+ score;
    }

    //negative result match
    public void matchResultneg()
    {
        getText();
        if( res1 != res2){
            score++;
           as1.Play();
        }else
            as2.Play();
        Debug.Log("score : "+score + " res1 : "+res1+" res2 : "+ res2);
       res1 =0 ;
        res2 = 0;
        text.text = "Score : "+ score;
        if(PlayerPrefs.GetInt("HighScore") < score)
            PlayerPrefs.SetInt("HighScore", score);
    }



   
}
