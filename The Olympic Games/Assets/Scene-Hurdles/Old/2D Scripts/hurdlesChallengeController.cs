using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurdlesChallengeController : MonoBehaviour {

	public float scrollSpeed = 5.0f;
	bool isGameOver = false;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isGameOver) return;
		//Scrolling
		GameObject currentChild;
		for (int i = 0; i < transform.childCount; i++) 
		{
			currentChild = transform.GetChild (i).gameObject;
			ScrollChallenge
			(currentChild);
//			if (currentChild.transform.position.x <= -70.0f) 
//			{
//				Destroy (currentChild);
//			}
		}

		
	}

	void ScrollChallenge(GameObject currentChallenge)
	{
		currentChallenge.transform.position -= Vector3.right * (scrollSpeed * Time.deltaTime);
	}

	public void GameOver ()
	{
		isGameOver = true;
	}
}
