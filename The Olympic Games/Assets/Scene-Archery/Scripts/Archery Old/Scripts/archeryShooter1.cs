using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class archeryShooter1 : MonoBehaviour {

	Vector2 mouseLook;
	[SerializeField]
	private GameObject arrowPrefab;
	int counter = 0;
	public Camera camera1;
	public Text Level1Text;
	public Text Level1ClickToPlayText;

	// Use this for initialization
	void Start () 
	{
		arrowPrefab = Resources.Load ("Arrow") as GameObject;
		camera1.enabled = true;
		Level1Text.enabled = true;
		Level1ClickToPlayText.enabled = true;
	}

	// Update is called once per frame
	void Update ()
	{
		if(counter == 1 || counter == 2 || counter == 3 || counter == 4 || counter == 5) 
		{
			if (Input.GetMouseButtonDown (0)) 
			{
				GameObject newArrow = Instantiate (arrowPrefab) as GameObject;
				newArrow.transform.position = transform.position;
				Rigidbody rb = newArrow.GetComponent<Rigidbody> ();
				rb.velocity = Camera.main.transform.forward * 30;
			}
		}
		if (counter == 1) 
		{
			Level1Text.enabled = false;
			Level1ClickToPlayText.enabled = false;
		}
		CountArrow ();
	}

	void CountArrow ()
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			counter = counter + 1;
		}
			
		if (counter == 7) 
		{
			Destroy (this.gameObject);
		}
	}
}
