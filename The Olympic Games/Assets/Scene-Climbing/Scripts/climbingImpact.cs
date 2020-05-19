using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class climbingImpact : MonoBehaviour {

	public GameObject impactPrefab;
	public int value = 100;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D coll)
	{
		GameObject _canvas = Instantiate (impactPrefab, coll.transform.position, coll.transform.rotation) as GameObject;
		//		_canvas.GetComponentInChildren<RectTransform> ().position = Camera.main.WorldToScreenPoint (coll.transform.position);
		_canvas.GetComponentInChildren<Text> ().text = "+" + value.ToString ();
		Destroy (_canvas, 3);
	}
}
