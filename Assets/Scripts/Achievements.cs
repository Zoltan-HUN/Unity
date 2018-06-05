using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Achievements : MonoBehaviour {
	public GameObject tc5, tc10,tc50, tc100,cactus_tick,lasere,maxlife;

	public int score,c_killed,a_shooted;
	public string a_fivescore,a_tenscore,a_fiftyscore,a_hundredscore,monster_killed,hundred_shoot;

	// Use this for initialization
	void Start () {
		tc5.gameObject.SetActive (false);
		tc10.gameObject.SetActive (false);
		tc50.gameObject.SetActive (false);
		tc100.gameObject.SetActive (false);
		cactus_tick.gameObject.SetActive (false);
		lasere.gameObject.SetActive (false);
		maxlife.gameObject.SetActive (false);


		score = PlayerPrefs.GetInt ("highscore", ScoreScript.highscore);
		if (score >= 5) {
			a_fivescore = "COMPLETED_TC5";
			PlayerPrefs.SetString ("a_fivescore", a_fivescore);
		
		}
		if (score >= 10) {
			a_tenscore = "COMPLETED_TC10";
				PlayerPrefs.SetString ("a_tenscore", a_tenscore);
			}
		if (score >= 50) {
			a_fiftyscore = "COMPLETED_TC50";
				PlayerPrefs.SetString ("a_fiftyscore", a_fiftyscore);
				}
		if (score >= 100) {
				a_hundredscore = "COMPLETED_TC100";
				PlayerPrefs.SetString ("a_hundredscore", a_hundredscore);
			}


			c_killed = PlayerPrefs.GetInt("killed", EnemyCactus.killed);
		if (c_killed >= 10) {
			monster_killed = "KILLED_CACTUS";
			PlayerPrefs.SetString ("monster_killed", monster_killed);
		}
		a_shooted =  PlayerPrefs.GetInt ("shoots", LaserEye.shoots);
		if (a_shooted >= 100) {
			hundred_shoot = "COMPLETED_SHOOTS";
			PlayerPrefs.SetString ("hundred_shoot", hundred_shoot);
		}

	}
	
	// Update is called once per frame
	void Update () {
		PlayerPrefs.GetString ("a_fivescore", a_fivescore);
		if (a_fivescore == "COMPLETED_TC5") {
			tc5.gameObject.SetActive (true);
		}
		PlayerPrefs.GetString ("a_tenscore", a_tenscore);
		if (a_tenscore == "COMPLETED_TC10") {
			tc10.gameObject.SetActive (true);
		}
		PlayerPrefs.GetString ("a_fiftyscore", a_fiftyscore);
		if (a_fiftyscore == "COMPLETED_TC50") {
			tc50.gameObject.SetActive (true);
		}

		PlayerPrefs.GetString ("a_hundredscore", a_hundredscore);
		if (a_hundredscore == "COMPLETED_TC100") {
			tc100.gameObject.SetActive (true);
		}

		PlayerPrefs.GetString ("monster_killed", monster_killed);
		if (monster_killed == "KILLED_CACTUS") {
			cactus_tick.gameObject.SetActive (true);

		}
		PlayerPrefs.GetString ("hundred_shoot", hundred_shoot);
		if (hundred_shoot == "COMPLETED_SHOOTS") {
			lasere.gameObject.SetActive (true);
		}

	}
	public void Resetscores(){
		PlayerPrefs.GetInt ("shoots", LaserEye.shoots);
		PlayerPrefs.SetInt ("shoots", 0);

		PlayerPrefs.GetInt ("highscore", ScoreScript.highscore);
		PlayerPrefs.SetInt ("highscore", 0);

		PlayerPrefs.GetInt("killed", EnemyCactus.killed);
		PlayerPrefs.SetInt("killed", 0);


	}
}
