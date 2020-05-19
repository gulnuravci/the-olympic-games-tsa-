using UnityEngine;
using System.Collections;

public class ButtonLoadLevel : MonoBehaviour 
{
	public void GoToPage(string sceneName)
	{
		Application.LoadLevel (sceneName);
	}
}
