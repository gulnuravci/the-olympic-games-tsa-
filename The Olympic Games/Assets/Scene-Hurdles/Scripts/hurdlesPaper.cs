using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurdlesPaper : MonoBehaviour {

	void OnTriggerEnter ()
	{
		Destroy (this.gameObject);
	}
}
