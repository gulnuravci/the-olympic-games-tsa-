using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MusicVolume : MonoBehaviour {

	public Slider Volume;
	public AudioSource myMusic;
	public GameObject volumeSlider;
	public string volumeScene;
	public string homeScene;

	void Start()
	{
		volumeSlider.SetActive (false);
	}

	void Update () 
	{
		if (SceneManager.GetActiveScene ().name == volumeScene) 
		{
			volumeSlider.SetActive (true);
			myMusic.volume = Volume.value;
		}
		if (SceneManager.GetActiveScene ().name == homeScene) 
		{
			volumeSlider.SetActive (false);
		}
	}
}
