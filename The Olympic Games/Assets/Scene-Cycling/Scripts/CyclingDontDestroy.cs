using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CyclingDontDestroy : MonoBehaviour {

	public void Awake()
	{
		DontDestroyOnLoad(this);

		if (FindObjectsOfType(GetType()).Length > 1)
		{
			Destroy(gameObject);
		}
	}

	void Update()
	{
		if (SceneManager.GetActiveScene ().name == "Cycling Home") 
		{
			Destroy(gameObject);
		}
	}
}
