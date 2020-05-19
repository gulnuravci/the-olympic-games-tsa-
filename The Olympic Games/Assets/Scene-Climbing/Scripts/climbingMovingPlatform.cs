using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class climbingMovingPlatform : MonoBehaviour {

	// Use this for initialization
	public float jumpForce = 10f;
	public int leftRight;
	public bool switchUp;
	public float speed;
	public float maxX;
	public float speedMin;
	public float speedMax;
	public GameObject platform;


	void OnEnable ()
	{
		leftRight = Random.Range (0, 2);
		if (leftRight == 1) {
			switchUp = true;
		} 
		else 
		{
			switchUp = false;
		}
		speed = Random.Range (speedMin, speedMax);
	}

	void Update ()
	{
		MovementFunction ();
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.relativeVelocity.y <= 0f) 
		{
			Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D> ();
			if (rb != null) 
			{
				Vector2 velocity = rb.velocity;
				velocity.y = jumpForce;
				rb.velocity = velocity;

			}

			Destroy (this.gameObject);
		}
	}

	void MovementFunction ()
	{
		if (platform.transform.position.x >= maxX && switchUp == true) {
			switchUp = false;
			leftRight = 0;
		} 
		else if (platform.transform.position.x <= -maxX && switchUp == false) 
		{
			switchUp = true;
			leftRight = 1;
		} 
		else 
		{
			if (leftRight == 0) 
			{
				platform.transform.Translate (new Vector3 (-speed, 0, 0) * Time.deltaTime);
			} 
			else if (leftRight == 1) 
			{
				platform.transform.Translate (new Vector3 (speed, 0, 0) * Time.deltaTime);
			}
		}
	}
}
