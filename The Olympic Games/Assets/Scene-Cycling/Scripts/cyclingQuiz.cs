using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cyclingQuiz : MonoBehaviour {

	public GameObject questionBackground;

	public GameObject question;
	public GameObject questionAnswer1;
	public GameObject questionAnswer2;
	public GameObject questionAnswer3;
	public GameObject questionAnswer4;

	public GameObject thisHelmet;

	public GameObject rightBtn;
	public GameObject wrongBtn;
	public GameObject right;
	public GameObject wrong;

	public GameObject cyclist;


	string sceneName;

	void Start () 
	{
		questionBackground.SetActive (false);
		rightBtn.SetActive (false);
		wrongBtn.SetActive (false);
		right.SetActive (false);
		wrong.SetActive (false);

		question.SetActive(false);
		questionAnswer1.SetActive (false);
		questionAnswer2.SetActive (false);
		questionAnswer3.SetActive (false);
		questionAnswer4.SetActive (false);
	}

	void Update () 
	{
		if (GameObject.FindWithTag ("Wrong")) 
		{
			SceneManager.LoadScene("Cycling Fail");
		}

		if (GameObject.FindWithTag ("Right")) 
		{
			questionBackground.SetActive (false);
			rightBtn.SetActive (false);
			wrongBtn.SetActive (false);
			right.SetActive (false);

			question.SetActive (false);
			questionAnswer1.SetActive (false);
			questionAnswer2.SetActive (false);
			questionAnswer3.SetActive (false);
			questionAnswer4.SetActive (false);
			cyclist.SetActive (true);
			thisHelmet.SetActive (false);
		}
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (this.gameObject.tag == "Helmet") 
		{
			questionBackground.SetActive (true);
			question.SetActive (true);
			questionAnswer1.SetActive (true);
			questionAnswer2.SetActive (true);
			questionAnswer3.SetActive (true);
			questionAnswer4.SetActive (true);
//			thisHelmet.SetActive (false);
			cyclist.SetActive(false);
		}
	}
}
