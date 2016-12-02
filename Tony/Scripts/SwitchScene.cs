using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour 
{
	public string myScene;

	public void PlayScene()
	{
		SceneManager.LoadScene (myScene);
	}
}