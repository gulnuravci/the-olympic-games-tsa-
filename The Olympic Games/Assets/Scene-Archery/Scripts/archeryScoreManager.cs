using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class archeryScoreManager : MonoBehaviour 
{
	public int score = 0;
	public static archeryScoreManager instance;
	[SerializeField]
	Text scoreText;

//	private int counter;
//	private int arrowsLeft;
//	public Text arrowText;
	string sceneName;

	//Timer
	public Text counterText;
	float timing;

	void Start () 
	{
		instance = this;
//		counter = 0;
//		arrowsLeft = 20;


		//Timer
		counterText = GetComponent<Text> () as Text;
		timing = 60;
		Scene currentScene = SceneManager.GetActiveScene ();
		sceneName = currentScene.name;
	}
	
	// Update is called once per frame
	void Update () 
	{
		scoreText.text = "Points: " + score.ToString ();
//		arrowText.text = "Arrows: " + arrowsLeft.ToString ();
		CountingArrows ();


		//Timer
		if (sceneName != "Archery Score") 
		{
			timing = timing - 0.0065f;
			counterText.text = "Time:" + timing.ToString ("00");
		} 
	}

	void CountingArrows()
	{
//		if (Input.GetMouseButtonUp (0)) 
//		{
//			arrowsLeft = arrowsLeft - 1;
////			counter = counter + 1;
//		}

		if ((timing > 0 && timing < 1) || GameObject.FindWithTag("Finish")) 
		{
			if (PlayerPrefs.GetInt ("HighScore") < score) 
			{
				PlayerPrefs.SetInt ("HighScore", score);	
			}
			PlayerPrefs.SetInt ("YourScore", score);	
			SceneManager.LoadScene("Archery Score");
		}
	}


}
