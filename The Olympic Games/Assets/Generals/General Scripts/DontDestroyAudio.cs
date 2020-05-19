using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio : MonoBehaviour {

//	public GameObject audio;
//	public void Awake()
//	{
//		DontDestroyOnLoad(this);
//	}
//
//	void Update()
//	{
//		if (Application.loadedLevelName == "Stadium")
//		{
//			Destroy(audio);
//		}
//	}

	private static DontDestroyAudio _instance ;

	void Awake()
	{
		//if we don't have an [_instance] set yet
		if (!_instance)
			_instance = this;
		//otherwise, if we do, kill this thing
		else
			Destroy (this.gameObject);


		DontDestroyOnLoad (this.gameObject);
	}

	void Update()
	{
		if (Application.loadedLevelName == "Stadium")
		{
			Destroy (this.gameObject);
		}
	}
}
