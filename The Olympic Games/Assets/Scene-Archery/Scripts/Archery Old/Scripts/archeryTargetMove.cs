using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class archeryTargetMove : MonoBehaviour {
	int speedAmt = 10;

	// Use this for initialization
	void Start () 
	{
	 	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.x <= -95) 
		{
			speedAmt = 5;
		}

		if (transform.position.x >= -90) 
		{
			speedAmt = -5;
		}

		transform.Translate (speedAmt * Time.deltaTime, 0, 0);
	}
}
