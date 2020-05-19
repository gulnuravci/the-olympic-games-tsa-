using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swimmer : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		RenderSettings.fog = false;
		RenderSettings.fogColor = new Color (0.2f, 0.4f, 0.8f, 0.5f);
		RenderSettings.fogDensity = 0.04f;
	}

	bool isUnderwater()
	{
		return gameObject.transform.position.y < -6.8;
	}
	
	// Update is called once per frame
	void Update () 
	{
		RenderSettings.fog = isUnderwater ();	
	}
}
