using UnityEngine;
using UnityEngine.SceneManagement;

public class hurdlesRestartLevel : MonoBehaviour {

	void OnTriggerEnter ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
