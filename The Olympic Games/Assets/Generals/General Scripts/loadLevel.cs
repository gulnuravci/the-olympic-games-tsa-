using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadLevel : MonoBehaviour {

	public string Scene;

	void OnTriggerEnter (Collider other)
	{
		Application.LoadLevel (Scene);
	}


}
