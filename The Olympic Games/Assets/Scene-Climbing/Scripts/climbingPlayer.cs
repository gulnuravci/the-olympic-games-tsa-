using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class climbingPlayer : MonoBehaviour {

	public float movementSpeed = 10f;
	Rigidbody2D rb;
	public int score = 0;
	[SerializeField]
	public Text scoreText;

	[SerializeField]
	Vector3 _lastPosition;

	float movement = 0f;

	public GameObject lookingLeft;
	public GameObject lookingRight;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D> ();	
		_lastPosition = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		movement = Input.GetAxis ("Horizontal") * movementSpeed;
		scoreText.text = "Score: " + score.ToString ();
		if(this.transform.position.y - _lastPosition.y > 0) 
		{
			score = score + 1;
		}
		_lastPosition = this.transform.position;

		if(Input.GetKey(KeyCode.LeftArrow))
		{
			lookingLeft.GetComponent<SpriteRenderer> ().enabled = true;
			lookingRight.GetComponent<SpriteRenderer> ().enabled = false;
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			lookingLeft.GetComponent<SpriteRenderer> ().enabled = false;
			lookingRight.GetComponent<SpriteRenderer> ().enabled = true;
		}
	}

	void FixedUpdate()
	{
		Vector2 velocity = rb.velocity;
		velocity.x = movement;
		rb.velocity = velocity;
	}

//	void OnBecameInvisible() 
//	{
//		if(!GameObject.FindWithTag ("Question"))
//		{
//			if (PlayerPrefs.GetInt ("ClimbingHighScore") < score) 
//			{
//				PlayerPrefs.SetInt ("ClimbingHighScore", score);	
//			}
//			PlayerPrefs.SetInt ("ClimbingYourScore", score);	
//			Application.LoadLevel ("Climbing Score");
//		}
//	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Restart") 
		{
			if (PlayerPrefs.GetInt ("ClimbingHighScore") < score) 
			{
				PlayerPrefs.SetInt ("ClimbingHighScore", score);	
			}
			PlayerPrefs.SetInt ("ClimbingYourScore", score);	
			Application.LoadLevel ("Climbing Score");
		}

		if (other.gameObject.tag == "Rope") 
		{
			score = score + 100;
		}
	}
}
