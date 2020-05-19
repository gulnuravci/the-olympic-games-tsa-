using UnityEngine;
using UnityEngine.UI;

public class climbingScoreManager : MonoBehaviour 
{
	public Text highscoreText;
	public Text yourscoreText;

	void Start ()
	{
		highscoreText.text = "HighScore : " + PlayerPrefs.GetInt ("ClimbingHighScore");
		yourscoreText.text = "YourScore : " + PlayerPrefs.GetInt ("ClimbingYourScore");
	}
}
