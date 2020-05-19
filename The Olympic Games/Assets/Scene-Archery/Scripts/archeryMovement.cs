using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class archeryMovement : MonoBehaviour {

	public float speed = 10.0F;
	public bool onGround;
	private Rigidbody rb;

	void Start () 
	{
		//Cursor.lockState = CursorLockMode.Locked;
		onGround = true;
		rb = GetComponent<Rigidbody> ();
	}
		
	void Update ()
	{

		float translation = Input.GetAxis ("Vertical") * speed;
		float straffe = Input.GetAxis ("Horizontal") * speed;
		translation *= Time.deltaTime;
		straffe *= Time.deltaTime;

		transform.Translate (straffe, 0, translation);

		//		if (Input.GetKeyDown ("escape"))
		//			Cursor.lockState = CursorLockMode.None;

		if (onGround) 
		{
			if (Input.GetButtonDown ("Jump")) 
			{
				rb.velocity = new Vector3 (0f, 8f, 0f);
				onGround = false;
			}
		}

		if (GameObject.FindWithTag ("Question")) 
		{
			this.gameObject.GetComponentInChildren<archeryAim> ().enabled = false;
			this.gameObject.GetComponentInChildren<archeryShoot> ().enabled = false;
		} 
		else 
		{
			this.gameObject.GetComponentInChildren<archeryAim> ().enabled = true;
			this.gameObject.GetComponentInChildren<archeryShoot> ().enabled = true;
		}
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag ("Ground")) 
		{
			onGround = true;
		}
	}

//	void OnTriggerEnter(Collider col)
//	{
//		if (col.gameObject.tag == "Info") 
//		{
//			this.gameObject.GetComponentInChildren<canMouseLook> ().enabled = false;
//		}	
//	}
//
//	void OnTriggerExit(Collider col)
//	{
//		this.gameObject.GetComponentInChildren<archeryAim> ().enabled = true;
//	}
}