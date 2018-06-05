using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
	public Text text;
	public static int high_score;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		high_score = PlayerPrefs.GetInt ("highscore", ScoreScript.highscore);

	}
	
	// Update is called once per frame
	void Update () {


		text.text = "" + high_score;

		}
	public void Resetscore(){
		PlayerPrefs.GetInt ("highscore", ScoreScript.highscore);
		PlayerPrefs.SetInt ("highscore", 0);


	}

}
