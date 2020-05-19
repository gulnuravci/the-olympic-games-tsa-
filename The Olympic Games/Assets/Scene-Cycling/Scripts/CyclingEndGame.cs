using UnityEngine;
using UnityEngine.SceneManagement;

public class CyclingEndGame : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag != "Helmet") 
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}
}
