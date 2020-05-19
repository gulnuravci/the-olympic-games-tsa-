using UnityEngine;
using UnityEngine.UI;

public class cyclingHighScore : MonoBehaviour {

	public Text lowestTimeText;
	public Text yourTimeText;

	void Start ()
	{
//		lowestTimeText.text = "LowestTime : " + PlayerPrefs.GetInt("CyclingLowestTimeMinutes") + ":" + PlayerPrefs.GetInt ("CyclingLowestTimeSeconds");
//		yourTimeText.text = "YourTime : " + PlayerPrefs.GetInt ("CyclingYourTimeMinutes") + ":" + PlayerPrefs.GetInt ("CyclingYourTimeSeconds");

//		lowestTimeText.text = "Lowest Time: " + PlayerPrefs.GetString ("CyclingLowestTime"); 
		yourTimeText.text = "Your Time: " + PlayerPrefs.GetString ("CyclingYourTime"); 
	}
}
