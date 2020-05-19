using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cyclingNextLevel : MonoBehaviour {

	public string Scene;

	void OnTriggerEnter2D (Collider2D other)
	{
			Application.LoadLevel(Scene);
	}
}
