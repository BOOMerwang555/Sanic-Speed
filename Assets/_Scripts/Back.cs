using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour {

	public Button backButton;

	public void newGameButton(string newGameScene)
	{
		SceneManager.LoadScene (newGameScene);
	}
}
