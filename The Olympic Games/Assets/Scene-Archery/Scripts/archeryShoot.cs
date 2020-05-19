using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class archeryShoot : MonoBehaviour {
	[SerializeField]
	float pullSpeed;
	[SerializeField]
	GameObject arrowPrefab;
	[SerializeField]
	GameObject arrow;
//	[SerializeField]
	public int numberOfArrows = 10;
	[SerializeField]
	GameObject bow;
	bool arrowSlotted = false;
	float pullAmount = 0;

	int arrowCounter = 20;
	public GameObject finish;
//	private int arrowsLeft;
	public Text arrowText;

	// Use this for initialization
	void Start () 
	{
		SpawnArrow ();
		finish.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		ShootLogic ();
		arrowText.text = "Arrows: " + arrowCounter.ToString ();
		if (arrowCounter == 0) 
		{
			finish.SetActive (true);
		}
	}

	void SpawnArrow ()
	{
		if (numberOfArrows > 0) {
			arrowSlotted = true;
			arrow = Instantiate (arrowPrefab, transform.position, transform.rotation) as GameObject;
			arrow.transform.parent = transform;
		} 
	}

	void ShootLogic ()
	{
		if (numberOfArrows > 0) 
		{
			if (pullAmount > 100) 
			{
				pullAmount = 100;
			}

			SkinnedMeshRenderer _bowSkin = bow.transform.GetComponent<SkinnedMeshRenderer> ();
			SkinnedMeshRenderer _arrowSkin = arrow.transform.GetComponent<SkinnedMeshRenderer> ();
			Rigidbody _arrowRigidB = arrow.transform.GetComponent <Rigidbody> ();
			archeryProjectileAddForce _arrowProjectile = arrow.transform.GetComponent<archeryProjectileAddForce> ();

			if(Input.GetMouseButton(0))
			{
				pullAmount+=Time.deltaTime * pullSpeed;
			}

			if (Input.GetMouseButtonUp (0)) 
			{
				arrowSlotted = false;
				_arrowRigidB.isKinematic = false;
				arrow.transform.parent = null;
				_arrowProjectile.shootForce = _arrowProjectile.shootForce * ((pullAmount / 100) + .05f);

				pullAmount = 0;

				_arrowProjectile.enabled = true;

				arrowCounter = arrowCounter - 1;
			}

			_bowSkin.SetBlendShapeWeight (0, pullAmount);
			_arrowSkin.SetBlendShapeWeight (0, pullAmount);

			if (Input.GetMouseButtonDown (0) && arrowSlotted == false) 
			{
				SpawnArrow ();
			}
		}
	}
}
