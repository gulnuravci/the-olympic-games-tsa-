using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {

	Rigidbody rb;
	int counter = 0;
	GameObject target;

	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
	}

	void Update () 
	{
		transform.rotation = Quaternion.LookRotation (rb.velocity);
		CountArrow ();
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "Target")
		{
			rb.isKinematic = true;
		}
	}

	void CountArrow ()
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			counter = counter + 1;
		}

		if (counter == 5) 
		{
//			Application.LoadLevel (6);
		}
	}


}
