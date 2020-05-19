using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurdlesTileManager : MonoBehaviour {

	public GameObject[] tilePrefabs;

	private Transform playertransform;
	private float spawnX = 0.0f;
	private float tileLength = 19.0f;
	private float safeZone = 15.0f;
	private int amnTilesOnScreen = 13;
	private int lastPrefabIndex = 0;

	private List<GameObject> activeTiles;

	// Use this for initialization
	private void Start () 
	{
		activeTiles = new List<GameObject> ();
		playertransform = GameObject.FindGameObjectWithTag ("Player").transform;
		for (int i = 0; i < amnTilesOnScreen; i++) 
		{
			if (i < 2)
				SpawnTile (0);
			else
				SpawnTile ();
		}
	}
	
	// Update is called once per frame
	private void Update () 
	{
		if (playertransform.position.x - safeZone > (spawnX - amnTilesOnScreen * tileLength)) 
		{
			SpawnTile ();
			DeleteTile ();
		}
	}

	private void SpawnTile (int prefabIndex = -1)
	{
		GameObject go;
		if (prefabIndex == -1)
			go = Instantiate (tilePrefabs [RandomPrefabIndex ()]) as GameObject;
		else
			go = Instantiate (tilePrefabs [prefabIndex]) as GameObject;
		go.transform.SetParent (transform);
		go.transform.position = Vector3.right * spawnX;
		spawnX += tileLength;
		activeTiles.Add (go);
	}

	private void DeleteTile ()
	{
		Destroy (activeTiles [0]);
		activeTiles.RemoveAt (0);
	}

	private int RandomPrefabIndex()
	{
		if (tilePrefabs.Length <= 1)
			return 0;

		int randomIndex = lastPrefabIndex;
		while(randomIndex == lastPrefabIndex)
		{
			randomIndex = Random.Range (0, tilePrefabs.Length);
		}

		lastPrefabIndex = randomIndex;
		return randomIndex;
	}
}
