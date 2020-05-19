using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class archeryPointTracker : MonoBehaviour {
	[SerializeField]
	GameObject impactPrefab;
	public int value = 50;

	public GameObject questionBackground;

	public GameObject question;
	public GameObject questionAnswer1;
	public GameObject questionAnswer2;
	public GameObject questionAnswer3;
	public GameObject questionAnswer4;

	public GameObject twoquestion;
	public GameObject twoquestionAnswer1;
	public GameObject twoquestionAnswer2;

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
	public GameObject fivequestionImage;
	public GameObject fivequestionAnswer1;
	public GameObject fivequestionAnswer2;
	public GameObject fivequestionAnswer3;
	public GameObject fivequestionAnswer4;

	public GameObject sixquestion;
	public GameObject sixquestionAnswer1;
	public GameObject sixquestionAnswer2;
	public GameObject sixquestionAnswer3;
	public GameObject sixquestionAnswer4;

	public GameObject sevenquestion;
	public GameObject sevenquestionAnswer1;
	public GameObject sevenquestionAnswer2;
	public GameObject sevenquestionAnswer3;
	public GameObject sevenquestionAnswer4;

	public GameObject eightquestion;
	public GameObject eightquestionImage;
	public GameObject eightquestionAnswer1;
	public GameObject eightquestionAnswer2;
	public GameObject eightquestionAnswer3;
	public GameObject eightquestionAnswer4;

	public GameObject ninequestion;
	public GameObject ninequestionAnswer1;
	public GameObject ninequestionAnswer2;
	public GameObject ninequestionImage;

	public GameObject tenquestion;
	public GameObject tenquestionAnswer1;
	public GameObject tenquestionAnswer2;
	public GameObject tenquestionAnswer3;
	public GameObject tenquestionAnswer4;

	public GameObject thisTarget1;
	public GameObject thisTarget2;
	public GameObject thisTarget3;
	public GameObject thisTarget4;
	public GameObject thisTarget5;
	public GameObject thisTarget6;
	public GameObject thisTarget7;
	public GameObject thisTarget8;
	public GameObject thisTarget9;
	public GameObject thisTarget10;

	public GameObject rightBtn;
	public GameObject wrongBtn;
	public GameObject right;
	public GameObject wrong;

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

		twoquestion.SetActive(false);
		twoquestionAnswer1.SetActive (false);
		twoquestionAnswer2.SetActive (false);

		threequestion.SetActive(false);
		threequestionAnswer1.SetActive (false);
		threequestionAnswer2.SetActive (false);
		threequestionAnswer3.SetActive (false);
		threequestionAnswer4.SetActive (false);

		fourquestion.SetActive(false);
		fourquestionAnswer1.SetActive (false);
		fourquestionAnswer2.SetActive (false);
		fourquestionAnswer3.SetActive (false);
		fourquestionAnswer4.SetActive (false);

		fivequestion.SetActive(false);
		fivequestionImage.SetActive (false);
		fivequestionAnswer1.SetActive (false);
		fivequestionAnswer2.SetActive (false);
		fivequestionAnswer3.SetActive (false);
		fivequestionAnswer4.SetActive (false);

		sixquestion.SetActive(false);
		sixquestionAnswer1.SetActive (false);
		sixquestionAnswer2.SetActive (false);
		sixquestionAnswer3.SetActive (false);
		sixquestionAnswer4.SetActive (false);

		sevenquestion.SetActive(false);
		sevenquestionAnswer1.SetActive (false);
		sevenquestionAnswer2.SetActive (false);
		sevenquestionAnswer3.SetActive (false);
		sevenquestionAnswer4.SetActive (false);

		eightquestion.SetActive(false);
		eightquestionImage.SetActive (false);
		eightquestionAnswer1.SetActive (false);
		eightquestionAnswer2.SetActive (false);
		eightquestionAnswer3.SetActive (false);
		eightquestionAnswer4.SetActive (false);

		ninequestion.SetActive(false);
		ninequestionAnswer1.SetActive (false);
		ninequestionAnswer2.SetActive (false);
		ninequestionImage.SetActive (false);

		tenquestion.SetActive(false);
		tenquestionAnswer1.SetActive (false);
		tenquestionAnswer2.SetActive (false);
		tenquestionAnswer3.SetActive (false);
		tenquestionAnswer4.SetActive (false);
	}
	
	void Update () 
	{
		if (GameObject.FindWithTag ("Wrong")) 
		{
			questionBackground.SetActive (false);
			rightBtn.SetActive (false);
			wrongBtn.SetActive (false);
			wrong.SetActive (false);

			question.SetActive(false);
			questionAnswer1.SetActive (false);
			questionAnswer2.SetActive (false);
			questionAnswer3.SetActive (false);
			questionAnswer4.SetActive (false);

			twoquestion.SetActive(false);
			twoquestionAnswer1.SetActive (false);
			twoquestionAnswer2.SetActive (false);

			threequestion.SetActive(false);
			threequestionAnswer1.SetActive (false);
			threequestionAnswer2.SetActive (false);
			threequestionAnswer3.SetActive (false);
			threequestionAnswer4.SetActive (false);

			fourquestion.SetActive(false);
			fourquestionAnswer1.SetActive (false);
			fourquestionAnswer2.SetActive (false);
			fourquestionAnswer3.SetActive (false);
			fourquestionAnswer4.SetActive (false);

			fivequestion.SetActive(false);
			fivequestionImage.SetActive (false);
			fivequestionAnswer1.SetActive (false);
			fivequestionAnswer2.SetActive (false);
			fivequestionAnswer3.SetActive (false);
			fivequestionAnswer4.SetActive (false);

			sixquestion.SetActive(false);
			sixquestionAnswer1.SetActive (false);
			sixquestionAnswer2.SetActive (false);
			sixquestionAnswer3.SetActive (false);
			sixquestionAnswer4.SetActive (false);

			sevenquestion.SetActive(false);
			sevenquestionAnswer1.SetActive (false);
			sevenquestionAnswer2.SetActive (false);
			sevenquestionAnswer3.SetActive (false);
			sevenquestionAnswer4.SetActive (false);

			eightquestion.SetActive(false);
			eightquestionImage.SetActive (false);
			eightquestionAnswer1.SetActive (false);
			eightquestionAnswer2.SetActive (false);
			eightquestionAnswer3.SetActive (false);
			eightquestionAnswer4.SetActive (false);

			ninequestion.SetActive(false);
			ninequestionAnswer1.SetActive (false);
			ninequestionAnswer2.SetActive (false);
			ninequestionImage.SetActive (false);


			tenquestion.SetActive(false);
			tenquestionAnswer1.SetActive (false);
			tenquestionAnswer2.SetActive (false);
			tenquestionAnswer3.SetActive (false);
			tenquestionAnswer4.SetActive (false);
		}

		if (GameObject.FindWithTag ("Right")) 
		{
			archeryScoreManager.instance.score += 5;
			questionBackground.SetActive (false);
			rightBtn.SetActive (false);
			wrongBtn.SetActive (false);
			right.SetActive (false);

			question.SetActive (false);
			questionAnswer1.SetActive (false);
			questionAnswer2.SetActive (false);
			questionAnswer3.SetActive (false);
			questionAnswer4.SetActive (false);

			twoquestion.SetActive (false);
			twoquestionAnswer1.SetActive (false);
			twoquestionAnswer2.SetActive (false);

			threequestion.SetActive(false);
			threequestionAnswer1.SetActive (false);
			threequestionAnswer2.SetActive (false);
			threequestionAnswer3.SetActive (false);
			threequestionAnswer4.SetActive (false);

			fourquestion.SetActive(false);
			fourquestionAnswer1.SetActive (false);
			fourquestionAnswer2.SetActive (false);
			fourquestionAnswer3.SetActive (false);
			fourquestionAnswer4.SetActive (false);

			fivequestion.SetActive(false);
			fivequestionImage.SetActive (false);
			fivequestionAnswer1.SetActive (false);
			fivequestionAnswer2.SetActive (false);
			fivequestionAnswer3.SetActive (false);
			fivequestionAnswer4.SetActive (false);

			sixquestion.SetActive(false);
			sixquestionAnswer1.SetActive (false);
			sixquestionAnswer2.SetActive (false);
			sixquestionAnswer3.SetActive (false);
			sixquestionAnswer4.SetActive (false);

			sevenquestion.SetActive(false);
			sevenquestionAnswer1.SetActive (false);
			sevenquestionAnswer2.SetActive (false);
			sevenquestionAnswer3.SetActive (false);
			sevenquestionAnswer4.SetActive (false);

			eightquestion.SetActive(false);
			eightquestionImage.SetActive (false);
			eightquestionAnswer1.SetActive (false);
			eightquestionAnswer2.SetActive (false);
			eightquestionAnswer3.SetActive (false);
			eightquestionAnswer4.SetActive (false);

			ninequestion.SetActive(false);
			ninequestionAnswer1.SetActive (false);
			ninequestionAnswer2.SetActive (false);
			ninequestionImage.SetActive (false);

			tenquestion.SetActive(false);
			tenquestionAnswer1.SetActive (false);
			tenquestionAnswer2.SetActive (false);
			tenquestionAnswer3.SetActive (false);
			tenquestionAnswer4.SetActive (false);
		}
	}

	void OnTriggerEnter(Collider coll)
	{
		archeryScoreManager.instance.score += value;
		GameObject _canvas = Instantiate (impactPrefab, coll.transform.position, coll.transform.rotation) as GameObject;
//		_canvas.GetComponentInChildren<RectTransform> ().position = Camera.main.WorldToScreenPoint (coll.transform.position);
		_canvas.GetComponentInChildren<Text> ().text = value.ToString ();
		Destroy (_canvas, 3);
		questionBackground.SetActive (true);

		if (this.gameObject.tag == "Target1") 
		{
			question.SetActive (true);
			questionAnswer1.SetActive (true);
			questionAnswer2.SetActive (true);
			questionAnswer3.SetActive (true);
			questionAnswer4.SetActive (true);
			thisTarget1.SetActive (false);
		} 
		else if (this.gameObject.tag == "Target2") 
		{
			twoquestion.SetActive (true);
			twoquestionAnswer1.SetActive (true);
			twoquestionAnswer2.SetActive (true);
			thisTarget2.SetActive (false);
		} 
		else if (this.gameObject.tag == "Target3") 
		{
			threequestion.SetActive (true);
			threequestionAnswer1.SetActive (true);
			threequestionAnswer2.SetActive (true);
			threequestionAnswer3.SetActive (true);
			threequestionAnswer4.SetActive (true);
			thisTarget3.SetActive (false);
		} 
		else if (this.gameObject.tag == "Target4") 
		{
			fourquestion.SetActive(true);
			fourquestionAnswer1.SetActive (true);
			fourquestionAnswer2.SetActive (true);
			fourquestionAnswer3.SetActive (true);
			fourquestionAnswer4.SetActive (true);
			thisTarget4.SetActive (false);
		}
		else if (this.gameObject.tag == "Target5") 
		{
			fivequestion.SetActive(true);
			fivequestionImage.SetActive (true);
			fivequestionAnswer1.SetActive (true);
			fivequestionAnswer2.SetActive (true);
			fivequestionAnswer3.SetActive (true);
			fivequestionAnswer4.SetActive (true);
			thisTarget5.SetActive (false);
		}
		else if (this.gameObject.tag == "Target6") 
		{
			sixquestion.SetActive(true);
			sixquestionAnswer1.SetActive (true);
			sixquestionAnswer2.SetActive (true);
			sixquestionAnswer3.SetActive (true);
			sixquestionAnswer4.SetActive (true);
			thisTarget6.SetActive (false);
		}
		else if (this.gameObject.tag == "Target7") 
		{
			sevenquestion.SetActive(true);
			sevenquestionAnswer1.SetActive (true);
			sevenquestionAnswer2.SetActive (true);
			sevenquestionAnswer3.SetActive (true);
			sevenquestionAnswer4.SetActive (true);
			thisTarget7.SetActive (false);
		}
		else if (this.gameObject.tag == "Target8") 
		{
			eightquestion.SetActive(true);
			eightquestionImage.SetActive (true);
			eightquestionAnswer1.SetActive (true);
			eightquestionAnswer2.SetActive (true);
			eightquestionAnswer3.SetActive (true);
			eightquestionAnswer4.SetActive (true);
			thisTarget8.SetActive (false);
		}
		else if (this.gameObject.tag == "Target9") 
		{
			ninequestion.SetActive(true);
			ninequestionAnswer1.SetActive (true);
			ninequestionAnswer2.SetActive (true);
			ninequestionImage.SetActive (true);
			thisTarget9.SetActive (false);

		}
		else if (this.gameObject.tag == "Target10") 
		{
			tenquestion.SetActive(true);
			tenquestionAnswer1.SetActive (true);
			tenquestionAnswer2.SetActive (true);
			tenquestionAnswer3.SetActive (true);
			tenquestionAnswer4.SetActive (true);
			thisTarget10.SetActive (false);
		}
	}
}
