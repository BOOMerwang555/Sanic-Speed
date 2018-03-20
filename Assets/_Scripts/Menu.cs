using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public Button playButton;
	public Button quitButton;
	public Button helpButton;

	public void newGameButton(string newGameScene)
	{
		SceneManager.LoadScene (newGameScene);
	}

	public void quitGameButton()
	{
		Application.Quit ();
	}
}