using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerHurdles : MonoBehaviour {

	public float jumpPower = 10.0f;
	Rigidbody2D myRigidbody;
	bool isGrounded = false;
	float posX = 0.0f;
	bool isGameOver = false;
	hurdlesChallengeController myChallengeController;

	public Image PaperGray1;
	public Image Paper1Check;
	public Image Paper1Cross;

	public Image PaperGray2;
	public Image Paper2Check;
	public Image Paper2Cross;

	public Image PaperGray3;
	public Image Paper3Check;
	public Image Paper3Cross;

	public Image PaperGray4;
	public Image Paper4Check;
	public Image Paper4Cross;

	public Image PaperGray5;
	public Image Paper5Check;
	public Image Paper5Cross;

	void Start ()
	{
		myRigidbody = transform.GetComponent<Rigidbody2D> ();
		posX = transform.position.x;
		myChallengeController = GameObject.FindObjectOfType<hurdlesChallengeController> ();
		Paper1Check.enabled = false;
		Paper1Cross.enabled = false;
		Paper2Check.enabled = false;
		Paper2Cross.enabled = false;
		Paper3Check.enabled = false;
		Paper3Cross.enabled = false;
		Paper4Check.enabled = false;
		Paper4Cross.enabled = false;
		Paper5Check.enabled = false;
		Paper5Cross.enabled = false;
	}

	void FixedUpdate()
	{
		if (Input.GetKeyDown (KeyCode.Space) && isGrounded && !isGameOver) 
		{
			myRigidbody.AddForce (Vector3.up * (jumpPower * myRigidbody.mass * myRigidbody.gravityScale * 20.0f));
		}
		if (transform.position .x < posX) 
		{
			GameOver ();
			Application.LoadLevel(Application.loadedLevel);
		}
	}

	void GameOver ()
	{
		isGameOver = true;
		myChallengeController.GameOver ();
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.collider.tag == "Ground") 
		{
			isGrounded = true;
		}
	}

	void OnCollisionStay2D(Collision2D other)
	{
		if (other.collider.tag == "Ground") 
		{
			isGrounded = true;
		}
	}

	void OnCollisionExit2D(Collision2D other)
	{
		if (other.collider.tag == "Ground") 
		{
			isGrounded = false;
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Paper1") 
		{
			Paper1Check.enabled = true;
			Destroy(GameObject.FindWithTag("Paper1Checker"));
			Destroy(GameObject.FindWithTag("Paper1"));
			PaperGray1.enabled = false;
		}

		if (other.gameObject.tag == "Paper1Checker") 
		{
			Paper1Cross.enabled = true;
			PaperGray1.enabled = false;
		}

		if (other.gameObject.tag == "Paper2") 
		{
			Paper2Check.enabled = true;
			Destroy(GameObject.FindWithTag("Paper2Checker"));
			Destroy(GameObject.FindWithTag("Paper2"));
			PaperGray2.enabled = false;
		}

		if (other.gameObject.tag == "Paper2Checker") 
		{
			Paper2Cross.enabled = true;
			PaperGray2.enabled = false;
		}


		if (other.gameObject.tag == "Paper3") 
		{
			Paper3Check.enabled = true;
			Destroy(GameObject.FindWithTag("Paper3Checker"));
			Destroy(GameObject.FindWithTag("Paper3"));
			PaperGray3.enabled = false;
		}

		if (other.gameObject.tag == "Paper3Checker") 
		{
			Paper3Cross.enabled = true;
			PaperGray3.enabled = false;
		}


		if (other.gameObject.tag == "Paper4") 
		{
			Paper4Check.enabled = true;
			Destroy(GameObject.FindWithTag("Paper4Checker"));
			Destroy(GameObject.FindWithTag("Paper4"));
			PaperGray4.enabled = false;
		}

		if (other.gameObject.tag == "Paper4Checker") 
		{
			Paper4Cross.enabled = true;
			PaperGray4.enabled = false;
		}


		if (other.gameObject.tag == "Paper5") 
		{
			Paper5Check.enabled = true;
			Destroy(GameObject.FindWithTag("Paper5Checker"));
			Destroy(GameObject.FindWithTag("Paper5"));
			PaperGray5.enabled = false;
		}

		if (other.gameObject.tag == "Paper5Checker") 
		{
			Paper5Cross.enabled = true;
			PaperGray5.enabled = false;
		}

		if (other.gameObject.tag == "FinishTable") 
		{
			if(Paper1Check.enabled == true && Paper2Check.enabled == true && 
				Paper3Check.enabled == true && Paper4Check.enabled == true && 
				Paper5Check.enabled == true) 
				{
//					Application.LoadLevel ("Hurdle Good Job");
				} 
			else if (Paper1Check.enabled == false || Paper2Check.enabled == false || 
				Paper3Check.enabled == false || Paper4Check.enabled == false || 
				Paper5Check.enabled == false) 
			{
//				Application.LoadLevel("Hurdle Try Again");
			}
			
	}
}

		
}
	