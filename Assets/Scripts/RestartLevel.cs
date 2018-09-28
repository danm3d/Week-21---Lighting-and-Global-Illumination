using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
	public string sceneName = "Box Sample";
	public void Restart()
	{
		SceneManager.LoadScene(sceneName);
	}
}
