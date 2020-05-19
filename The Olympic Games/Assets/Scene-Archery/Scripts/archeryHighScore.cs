using UnityEngine;
using UnityEngine.UI;

public class archeryHighScore : MonoBehaviour 
{
	public Text highscoreText;
	public Text yourscoreText;

	void Start ()
	{
		highscoreText.text = "HighScore : " + PlayerPrefs.GetInt ("HighScore");
		yourscoreText.text = "YourScore : " + PlayerPrefs.GetInt ("YourScore");
	}
}
