using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countDown : MonoBehaviour {
	
	public Text counterText;
	public float timing;
	string sceneName;

	void Start()
	{
		counterText = GetComponent<Text> () as Text;
		timing = 60;
		Scene currentScene = SceneManager.GetActiveScene ();
		sceneName = currentScene.name;
	}

	void Update()
	{
		timing = timing - 0.0065f;
		counterText.text = "Time:" + timing.ToString ("00");

		if (timing < 0) 
		{
			SceneManager.LoadScene("Archery Score");
		}
	}

}
