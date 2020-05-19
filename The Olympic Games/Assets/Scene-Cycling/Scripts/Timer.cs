using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	public Text timerText;
	float timer = 0f;
	int seconds;
	int minutes;
	int hours;
	string timerString;

	string sceneName;

	void Start () 
	{
	}

	void Update ()
	{
		if (sceneName != "Cycling Score")
		{
//			minutes = (int)(Time.time / 60f);
//			seconds = (int)(Time.time % 60f);
//			counterText.text = "Time:" + minutes.ToString ("00") + ":" + seconds.ToString ("00");

			timer += Time.deltaTime;
			seconds = (int)(timer % 60);
			minutes = (int)(timer / 60) % 60;
			hours = (int)(timer / 3600) % 24;

			timerString = string.Format ("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);

			timerText.text = timerString;

			PlayerPrefs.SetInt ("CyclingYourTimeMinutes", minutes);
			PlayerPrefs.SetInt ("CyclingYourTimeSeconds", seconds);
			PlayerPrefs.SetInt ("CyclingLowestTimeMinutes", minutes);
			PlayerPrefs.SetInt ("CyclingLowestTimeSeconds", seconds);
			PlayerPrefs.SetString ("CyclingYourTime", timerString);
//			PlayerPrefs.SetString ("CyclingLowestTime", timerString);
			if (PlayerPrefs.GetInt ("CyclingLowestTimeMinutes") > minutes) 
			{
//				if (PlayerPrefs.GetInt ("CyclingLowestTimeSeconds") > seconds) 
//				{
					PlayerPrefs.SetString ("CyclingLowestTime", timerString);
//					PlayerPrefs.SetInt ("CyclingLowestTimeMinutes", minutes);
//					PlayerPrefs.SetInt ("CyclingLowestTimeSeconds", seconds);

//				}
			}
		}

		if(sceneName == "Cycling Score")
		{
			if (PlayerPrefs.GetInt ("CyclingLowestTimeMinutes") > minutes) 
			{
				if (PlayerPrefs.GetInt ("CyclingLowestTimeSeconds") > seconds) 
				{
					PlayerPrefs.SetString ("CyclingLowestTime", timerString);
				//	PlayerPrefs.SetInt ("CyclingLowestTimeMinutes", minutes);
				//	PlayerPrefs.SetInt ("CyclingLowestTimeSeconds", seconds);

				}
			}
		}
	}
}