using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hurdlesQuiz : MonoBehaviour {

	public GameObject questionBackground;

	public GameObject onequestion;
	public GameObject onequestionAnswer1;
	public GameObject onequestionAnswer2;
	public GameObject onequestionAnswer3;
	public GameObject onequestionAnswer4;

	public GameObject twoquestion;
	public GameObject twoquestionAnswer1;
	public GameObject twoquestionAnswer2;
	public GameObject twoquestionAnswer3;
	public GameObject twoquestionAnswer4;

	public GameObject threequestion;
	public GameObject threequestionAnswer1;
	public GameObject threequestionAnswer2;
	public GameObject threequestionAnswer3;
	public GameObject threequestionAnswer4;

	public GameObject fourquestion;
	public GameObject fourquestionAnswer1;
	public GameObject fourquestionAnswer2;
	public GameObject fourquestionAnswer3;
	public GameObject fourquestionAnswer4;

	public GameObject fivequestion;
	public GameObject fivequestionAnswer1;
	public GameObject fivequestionAnswer2;

	public GameObject hurdles1;
	public GameObject hurdles2;
	public GameObject hurdles3;
	public GameObject hurdles4;
	public GameObject hurdles5;

	public GameObject wrongBtn;
	public GameObject rightBtn;
	public GameObject wrong;
	public GameObject right;

	public GameObject runner;
	public GameObject camera;

	void Update () 
	{
		if (GameObject.FindWithTag ("Wrong")) 
		{
			SceneManager.LoadScene("Hurdles Score");
		}
		if (GameObject.FindWithTag ("Right")) 
		{
			runner.GetComponent<hurdlesPlayerMovement> ().enabled = true;
			runner.GetComponent<hurdlesScore> ().enabled = true;
			camera.GetComponent<hurdlesLook> ().enabled = true;
//			archeryScoreManager.instance.score += 5;
			questionBackground.SetActive (false);
			rightBtn.SetActive (false);
			wrongBtn.SetActive (false);
			right.SetActive (false);

			onequestion.SetActive (false);
			onequestionAnswer1.SetActive (false);
			onequestionAnswer2.SetActive (false);
			onequestionAnswer3.SetActive (false);
			onequestionAnswer4.SetActive (false);

			twoquestion.SetActive (false);
			twoquestionAnswer1.SetActive (false);
			twoquestionAnswer2.SetActive (false);
			twoquestionAnswer3.SetActive (false);
			twoquestionAnswer4 .SetActive (false);

			threequestion.SetActive (false);
			threequestionAnswer1.SetActive (false);
			threequestionAnswer2.SetActive (false);
			threequestionAnswer3.SetActive (false);
			threequestionAnswer4.SetActive (false);

			fourquestion.SetActive (false);
			fourquestionAnswer1.SetActive (false);
			fourquestionAnswer2.SetActive (false);
			fourquestionAnswer3.SetActive (false);
			fourquestionAnswer4.SetActive (false);

			fivequestion.SetActive (false);
			fivequestionAnswer1.SetActive (false);
			fivequestionAnswer2.SetActive (false);
		}
	}

	void OnTriggerEnter(Collider coll)
	{
		if (this.gameObject.tag == "Hurdle1") 
		{
			questionBackground.SetActive (true);
			onequestion.SetActive (true);
			onequestionAnswer1.SetActive (true);
			onequestionAnswer2.SetActive (true);
			onequestionAnswer3.SetActive (true);
			onequestionAnswer4.SetActive (true);
			runner.GetComponent<hurdlesPlayerMovement>().enabled = false;
			runner.GetComponent<hurdlesScore>().enabled = false;
			camera.GetComponent<hurdlesLook> ().enabled = false;
			hurdles1.SetActive (false);
		}
		if (this.gameObject.tag == "Hurdle2") 
		{
			questionBackground.SetActive (true);
			twoquestion.SetActive (true);
			twoquestionAnswer1.SetActive (true);
			twoquestionAnswer2.SetActive (true);
			twoquestionAnswer3.SetActive (true);
			twoquestionAnswer4.SetActive (true);
			runner.GetComponent<hurdlesPlayerMovement>().enabled = false;
			runner.GetComponent<hurdlesScore>().enabled = false;
			camera.GetComponent<hurdlesLook> ().enabled = false;
			hurdles2.SetActive (false);
		}
		if (this.gameObject.tag == "Hurdle3") 
		{			
			questionBackground.SetActive (true);
			threequestion.SetActive (true);
			threequestionAnswer1.SetActive (true);
			threequestionAnswer2.SetActive (true);
			threequestionAnswer3.SetActive (true);
			threequestionAnswer4.SetActive (true);
			runner.GetComponent<hurdlesPlayerMovement>().enabled = false;
			runner.GetComponent<hurdlesScore>().enabled = false;
			camera.GetComponent<hurdlesLook> ().enabled = false;
			hurdles3.SetActive (false);
		}
		if (this.gameObject.tag == "Hurdle4") 
		{
			questionBackground.SetActive (true);
			fourquestion.SetActive(true);
			fourquestionAnswer1.SetActive (true);
			fourquestionAnswer2.SetActive (true);
			fourquestionAnswer3.SetActive (true);
			fourquestionAnswer4.SetActive (true);
			runner.GetComponent<hurdlesPlayerMovement>().enabled = false;
			runner.GetComponent<hurdlesScore>().enabled = false;
			camera.GetComponent<hurdlesLook> ().enabled = false;
			hurdles4.SetActive (false);
		}
		if (this.gameObject.tag == "Hurdle5") 
		{
			questionBackground.SetActive (true);
			fivequestion.SetActive(true);
			fivequestionAnswer1.SetActive (true);
			fivequestionAnswer2.SetActive (true);
			runner.GetComponent<hurdlesPlayerMovement>().enabled = false;
			runner.GetComponent<hurdlesScore>().enabled = false;
			camera.GetComponent<hurdlesLook> ().enabled = false;
			hurdles5.SetActive (false);
		}
	}
}
