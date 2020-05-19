using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class swimmingPlayer : MonoBehaviour {


	public float speed = 10.0F;
	public bool onGround;
	private Rigidbody rb;

	// Use this for initialization
	void Start () 
	{
		Cursor.lockState = CursorLockMode.Locked;
		onGround = true;
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update ()
	{

		float translation = Input.GetAxis ("Vertical") * speed;
		float straffe = Input.GetAxis ("Horizontal") * speed;
		translation *= Time.deltaTime;
		straffe *= Time.deltaTime;

		transform.Translate (straffe, 0, translation);

		if (Input.GetKeyDown ("escape"))
			Cursor.lockState = CursorLockMode.None;

		if (onGround) {
			if (Input.GetButtonDown ("Jump")) {
				rb.velocity = new Vector3 (0f, 8f, 0f);
				onGround = false;
			}
		}
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag ("Ground")) 
		{
			onGround = true;
		}
	}
}
