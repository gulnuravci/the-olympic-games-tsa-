using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hurdlesScore : MonoBehaviour {

	private float score = 0.0f;

	private int difficultyLevel = 1;
	private int maxDifficultyLevel = 10;
	private int scoreToNextLevel = 10;

//	public Material[] skybox;

	public Text scoreText;

	void Update () 
	{
		if (score >= scoreToNextLevel)
			LevelUp ();
		score += Time.deltaTime * difficultyLevel;
		scoreText.text = ((int)score).ToString ();	
	}

	void LevelUp ()
	{
		if (difficultyLevel == maxDifficultyLevel)
			return;
		scoreToNextLevel *= 2;
		difficultyLevel++;
		GetComponent<hurdlesPlayerMovement> ().SetSpeed (difficultyLevel);
//		int x = Random.Range (0, skybox.Length);
//		RenderSettings.skybox = skybox[x];
//		Debug.Log (difficultyLevel);
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Paper") 
		{
			score = score + 30;
		}
		if (other.gameObject.tag == "Hurdle" || GameObject.FindWithTag ("Finish")) 
		{
			PlayerPrefs.SetInt("HurdlesYourScore", (int) score);
			if (PlayerPrefs.GetInt ("HurdlesHighScore") < score) 
			{
				PlayerPrefs.SetInt ("HurdlesHighScore", (int) score);	
			}
			Application.LoadLevel ("Hurdles Score");
		}
	}
}
