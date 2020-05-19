using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class climbingQuiz : MonoBehaviour {

	public GameObject questionBackground;

	public GameObject question;
	public GameObject questionAnswer1;
	public GameObject questionAnswer2;
	public GameObject questionAnswer3;
	public GameObject questionAnswer4;

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

	public GameObject eightquestion;
	public GameObject eightquestionAnswer1;
	public GameObject eightquestionAnswer2;
	public GameObject eightquestionAnswer3;
	public GameObject eightquestionAnswer4;

	public GameObject ninequestion;
	public GameObject ninequestionAnswer1;
	public GameObject ninequestionAnswer2;
	public GameObject ninequestionAnswer3;
	public GameObject ninequestionAnswer4;

	public GameObject tenquestion;
	public GameObject tenquestionAnswer1;
	public GameObject tenquestionAnswer2;
	public GameObject tenquestionAnswer3;
	public GameObject tenquestionAnswer4;

//	public GameObject rightBtn;
	public GameObject wrong;

	public GameObject climber;

	public float jumpForce = 10f;

	string sceneName;

	void Start () 
	{
		questionBackground.SetActive (false);
		wrong.SetActive (false);

		question.SetActive(false);
		questionAnswer1.SetActive (false);
		questionAnswer2.SetActive (false);
		questionAnswer3.SetActive (false);
		questionAnswer4.SetActive (false);

		twoquestion.SetActive(false);
		twoquestionAnswer1.SetActive (false);
		twoquestionAnswer2.SetActive (false);
		twoquestionAnswer3.SetActive (false);
		twoquestionAnswer4.SetActive (false);

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

		eightquestion.SetActive(false);
		eightquestionAnswer1.SetActive (false);
		eightquestionAnswer2.SetActive (false);
		eightquestionAnswer3.SetActive (false);
		eightquestionAnswer4.SetActive (false);

		ninequestion.SetActive(false);
		ninequestionAnswer1.SetActive (false);
		ninequestionAnswer2.SetActive (false);
		ninequestionAnswer3.SetActive (false);
		ninequestionAnswer4.SetActive (false);

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
			SceneManager.LoadScene("Climbing Score");
		}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.relativeVelocity.y <= 0f) 
		{
			Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D> ();
			if (rb != null) 
			{
				questionBackground.SetActive (true);
				climber.SetActive (false);
		
				if (this.gameObject.tag == "ClimbingQ1") 
				{
					question.SetActive (true);
					questionAnswer1.SetActive (true);
					questionAnswer2.SetActive (true);
					questionAnswer3.SetActive (true);
					questionAnswer4.SetActive (true);
				} 
				else if (this.gameObject.tag == "ClimbingQ2") 
				{
					twoquestion.SetActive (true);
					twoquestionAnswer1.SetActive (true);
					twoquestionAnswer2.SetActive (true);
					twoquestionAnswer3.SetActive (true);
					twoquestionAnswer4.SetActive (true);
				} 
				else if (this.gameObject.tag == "ClimbingQ3") 
				{
					threequestion.SetActive (true);
					threequestionAnswer1.SetActive (true);
					threequestionAnswer2.SetActive (true);
					threequestionAnswer3.SetActive (true);
					threequestionAnswer4.SetActive (true);
				} 
				else if (this.gameObject.tag == "ClimbingQ4") 
				{
					fourquestion.SetActive(true);
					fourquestionAnswer1.SetActive (true);
					fourquestionAnswer2.SetActive (true);
					fourquestionAnswer3.SetActive (true);
					fourquestionAnswer4.SetActive (true);
				}
				else if (this.gameObject.tag == "ClimbingQ5") 
				{
					fivequestion.SetActive(true);
					fivequestionAnswer1.SetActive (true);
					fivequestionAnswer2.SetActive (true);
					fivequestionAnswer3.SetActive (true);
					fivequestionAnswer4.SetActive (true);
				}
				else if (this.gameObject.tag == "ClimbingQ6") 
				{
					sixquestion.SetActive(true);
					sixquestionAnswer1.SetActive (true);
					sixquestionAnswer2.SetActive (true);
					sixquestionAnswer3.SetActive (true);
					sixquestionAnswer4.SetActive (true);
				}
				else if (this.gameObject.tag == "ClimbingQ7") 
				{
					sevenquestion.SetActive(true);
					sevenquestionAnswer1.SetActive (true);
					sevenquestionAnswer2.SetActive (true);
				}
				else if (this.gameObject.tag == "ClimbingQ8") 
				{
					eightquestion.SetActive(true);
					eightquestionAnswer1.SetActive (true);
					eightquestionAnswer2.SetActive (true);
					eightquestionAnswer3.SetActive (true);
					eightquestionAnswer4.SetActive (true);
				}
				else if (this.gameObject.tag == "ClimbingQ9") 
				{
					ninequestion.SetActive(true);
					ninequestionAnswer1.SetActive (true);
					ninequestionAnswer2.SetActive (true);
					ninequestionAnswer3.SetActive (true);
					ninequestionAnswer4.SetActive (true);
				}
				else if (this.gameObject.tag == "ClimbingQ10") 
				{
					tenquestion.SetActive(true);
					tenquestionAnswer1.SetActive (true);
					tenquestionAnswer2.SetActive (true);
					tenquestionAnswer3.SetActive (true);
					tenquestionAnswer4.SetActive (true);
				}
			}
		}
	}	
}
