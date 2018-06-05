using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour {

	public GameObject heart, heart2, heart3, gameOver;
	public static int health;
	public GameObject mpanel;



	void Start () {
		health = 3;
		heart.gameObject.SetActive (true);
		heart2.gameObject.SetActive (true);
		heart3.gameObject.SetActive (true);
		gameOver.gameObject.SetActive (false);
		mpanel.gameObject.SetActive (false);
	}
	

	void Update () {
		if (health > 3)
			health = 3;
		switch (health) {
		case 3:
			heart.gameObject.SetActive (true);
			heart2.gameObject.SetActive (true);
			heart3.gameObject.SetActive (true);
			break;
		case 2:
			heart.gameObject.SetActive (true);
			heart2.gameObject.SetActive (true);
			heart3.gameObject.SetActive (false);
			break;
		case 1:
			heart.gameObject.SetActive (true);
			heart2.gameObject.SetActive (false);
			heart3.gameObject.SetActive (false);
			break;
		case 0:
			heart.gameObject.SetActive (false);
			heart2.gameObject.SetActive (false);
			heart3.gameObject.SetActive (false);
			gameOver.gameObject.SetActive (true);
			mpanel.gameObject.SetActive (true);
			//Time.timeScale = 0;
	
			break;
			}
	//	if (Input.GetButton ("Jump")) {


	//		Endgame ();

	//	}

	}

}
