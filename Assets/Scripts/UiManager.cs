using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UiManager : MonoBehaviour {

	public Button[] buttons;
	public Text scoreText;
	bool gameOver;
	int score;

	// Use this for initialization
	void Start () {
		gameOver = false;
		score = 0;
		InvokeRepeating ("scoreUpdate", 1.0f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + score;
	}

	void scoreUpdate(){
		if (gameOver==false) {
			score += 1;
		}
	}

	public void gameOverActivated(){
		gameOver = true;
		Time.timeScale = 0;
		foreach (Button button in buttons) {
			button.gameObject.SetActive (true);
		}

	}
		

	public void Pause(){
		if (Time.timeScale == 1) {
			Time.timeScale = 0;
		} else {
			Time.timeScale = 1;
		}
	}

	public void Replay(){
		Application.LoadLevel (Application.loadedLevel);
		Time.timeScale = 1;
	}

	public void Menu(){
		Application.LoadLevel ("menuScene");
	}
	public void Exit(){
		Application.Quit();
	}
}
