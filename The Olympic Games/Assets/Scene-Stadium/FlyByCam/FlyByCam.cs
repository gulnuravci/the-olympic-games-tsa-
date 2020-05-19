using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyByCam : MonoBehaviour {

	public Camera flybycamera;
	public Camera playercamera;

	void Start () 
	{
		playercamera.enabled = false;
		flybycamera.enabled = true;
	}

	public void AlertObservers(string message)
	{
		if (message.Equals("FlyByEnd"))
		{
			playercamera.enabled = true;
			flybycamera.enabled = false;
		}
	}
}
