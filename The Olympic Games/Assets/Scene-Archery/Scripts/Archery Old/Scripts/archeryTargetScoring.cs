using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class archeryTargetScoring : MonoBehaviour {

	private int count;
	public Text countText;
	public Image Arrow1;
	public Image Arrow2;
	public Image Arrow3; 
	public Image Arrow4; 
	public Image Arrow5; 
	public Text Level1ScoreDisplay;

	private int countingclicks;

	void Start ()
	{
		count = 0;
//		SetCountText ();
		Level1ScoreDisplay.enabled = false;
	}

	void Update()
	{
		CountingClicks ();
		if (countingclicks == 7) 
		{
			Level1ScoreDisplay.enabled = false;
		}

		if (countingclicks == 6) 
		{
			Level1ScoreDisplay.enabled = true;
			Level1ScoreDisplay.text = "Score:" + count.ToString ();
		}
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Arrow")) 
		{
			count = count + 10;
			SetCountText();
		}
	}

	void SetCountText ()
	{
		countText.text = "Count:" + count.ToString ();
	}

	void CountingClicks ()
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			countingclicks = countingclicks + 1;
		}
		if (countingclicks == 0) 
		{
			Arrow1.enabled = false;
			Arrow2.enabled = false;
			Arrow3.enabled = false;
			Arrow4.enabled = false;
			Arrow5.enabled = false;
		}
		if (countingclicks == 1) 
		{
			Arrow1.enabled = true;
			Arrow2.enabled = true;
			Arrow3.enabled = true;
			Arrow4.enabled = true;
			Arrow5.enabled = true;
		}
		if (countingclicks == 2 || countingclicks == 9 || countingclicks == 16 || countingclicks == 23 || countingclicks == 30)  
		{
			Arrow1.enabled = false;
		}
		if (countingclicks == 3 || countingclicks == 10 || countingclicks == 17 || countingclicks == 24 || countingclicks == 31) 
		{
			Arrow2.enabled = false;
		}
		if (countingclicks == 4 || countingclicks == 11 || countingclicks == 18 || countingclicks == 25 || countingclicks == 32) 
		{
			Arrow3.enabled = false;
		}
		if (countingclicks == 5 || countingclicks == 12 || countingclicks == 19 || countingclicks == 26 || countingclicks == 33) 
		{
			Arrow4.enabled = false;
		}
		if (countingclicks == 6 || countingclicks == 13 || countingclicks == 20 || countingclicks == 27 || countingclicks == 34) 
		{
			Arrow5.enabled = false;
		}
		if (countingclicks == 8 || countingclicks == 15 || countingclicks == 22 || countingclicks == 29) 
		{
			Arrow1.enabled = true;
			Arrow2.enabled = true;
			Arrow3.enabled = true;
			Arrow4.enabled = true;
			Arrow5.enabled = true;
		}
	}


}
