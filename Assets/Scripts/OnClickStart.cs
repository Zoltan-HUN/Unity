using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OnClickStart : MonoBehaviour {
	public GameObject panel,panel2,panel3;


	// Use this for initialization
	void Start () {
		panel.gameObject.SetActive (false);
		panel2.gameObject.SetActive (false);
		panel3.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {

	}

	public void LoadByIndex()
		{
			SceneManager.LoadScene (1);
		}

	public void Quit()
	{
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		#else
			Application.Quit();
		#endif
	// Update is called once per frame
	}
	public void SwitchShowHideAchievement(){
		panel3.gameObject.SetActive (true);
	}
	public void SwitchShowHideHigscores(){
		panel2.gameObject.SetActive (true);
	}
	public void SwitchShowHideControls (){

		panel.gameObject.SetActive (true);

	}
	public void BackPanelControls(){
		panel.gameObject.SetActive (false);
	}
	public void BackPanelHighscores(){
		panel2.gameObject.SetActive (false);
	}
	public void BackPanelAchievement(){
		panel3.gameObject.SetActive (false);
	}
	public void backToMain(){


		SceneManager.LoadScene (0);



	}
}
