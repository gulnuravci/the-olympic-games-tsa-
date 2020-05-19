using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hurdlesPlayerMovement : MonoBehaviour {

	public float speed;
	Rigidbody rigid;
//	public int paperScore = 0;
//	public Text papersText;
	public bool onGround;
	public GameObject player;

	void Start () 
	{
		rigid = GetComponent<Rigidbody> ();	
		onGround = true;
//		player = GameObject.FindGameObjectWithTag("Player");
	}

	void Update () 
	{
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
//		papersText.text = "Paperwork: " + paperScore.ToString ();

//		float translation = Input.GetAxis ("Vertical") * speed;
//		float straffe = Input.GetAxis ("Horizontal") * speed;
//		translation *= Time.deltaTime;
//		straffe *= Time.deltaTime;
//
//		transform.Translate (straffe, 0, translation);

		if (onGround) 
		{
			if (Input.GetButtonDown ("Jump")) {
				rigid.velocity = new Vector3 (0f, 5.5f, 0f);
				onGround = false;
			}
		}
		if (player.transform.position.y < -0.01) 
		{
			Application.LoadLevel ("Hurdles Score");
		}
	}
		
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag ("Ground")) 
		{
			onGround = true;
		}
		if (other.gameObject.tag == "Restart") 
		{
			Application.LoadLevel ("Hurdles Score");
		}

	}

	public void SetSpeed(float modifier)
	{
//		speed = 5.0f + modifier;
		speed = 0.5f + modifier;
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Paper") 
		{
//			paperScore = paperScore + 1;
		}
//		if (other.gameObject.tag == "Hurdle") 
//		{
//			PlayerPrefs.SetInt("HurdlesPaperYourScore", (int) paperScore);
//			if (PlayerPrefs.GetInt ("HurdlesPaperHighScore") < paperScore) 
//			{
//				PlayerPrefs.SetInt ("HurdlesPaperHighScore", (int) paperScore);	
//			}
//		}
	}
}