using UnityEngine;
using UnityEngine.UI;

public class hurdlesHighScore : MonoBehaviour {

	public Text highscoreText;
	public Text yourscoreText;
//	public Text highscorePaperText;
//	public Text yourscorePaperText;

	void Start ()
	{
		highscoreText.text = "HighScore : " + PlayerPrefs.GetInt ("HurdlesHighScore");
		yourscoreText.text = "YourScore : " + PlayerPrefs.GetInt ("HurdlesYourScore");
//		highscorePaperText.text = "PaperHighScore : " + PlayerPrefs.GetInt ("HurdlesPaperHighScore");
//		yourscorePaperText.text = "PaperYourScore : " + PlayerPrefs.GetInt ("HurdlesPaperYourScore");
	}
}
