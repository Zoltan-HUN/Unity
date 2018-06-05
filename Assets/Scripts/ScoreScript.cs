using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour {

	// Use this for initialization

	public static int scoreValue;
	public static int highscore;
	Text score;


	void Start () {
		score = GetComponent<Text> ();
		scoreValue = 0;
		highscore = PlayerPrefs.GetInt ("highscore", highscore);

	}
	
	// Update is called once per frame
	void Update () {
		if (scoreValue > highscore) {
		
			highscore = scoreValue;
			PlayerPrefs.SetInt ("highscore", highscore);
		}

		score.text = "" + scoreValue;

	}



}
