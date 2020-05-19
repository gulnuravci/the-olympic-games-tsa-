using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stadiumInfo : MonoBehaviour {

	public GameObject uiImage;
	public GameObject background;

	// Use this for initialization
	void Start () 
	{
		uiImage.SetActive (false);
		background.SetActive (false);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			uiImage.SetActive (true);
			background.SetActive (true);
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			uiImage.SetActive (false);
			background.SetActive (false);
		}
	}

}
