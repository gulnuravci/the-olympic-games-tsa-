using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyByEnd : MonoBehaviour {

	public string Scene;

	public void AlertObservers(string message)
	{
		if (message.Equals("FlyByEnd"))
		{
			Application.LoadLevel(Scene);
		}
	}
}
