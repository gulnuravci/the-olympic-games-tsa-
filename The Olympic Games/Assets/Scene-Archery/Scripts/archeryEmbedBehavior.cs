using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class archeryEmbedBehavior : MonoBehaviour {
	Rigidbody rigidB;

	// Use this for initialization
	void Start () 
	{
		rigidB = GetComponent<Rigidbody> ();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider coll)
	{
//		if (coll.gameObject.tag != "Tree") 
//		{
			Embed ();
			transform.parent = coll.transform.parent;
//		}
	}

	void Embed ()
	{
		GetComponent<Collider> ().enabled = false;
		transform.GetComponent<archeryProjectileAddForce> ().enabled = false;
		rigidB.velocity = Vector3.zero;
		rigidB.useGravity = false;
		rigidB.isKinematic = true;
	}
}
