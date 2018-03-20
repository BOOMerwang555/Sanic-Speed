using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public GameObject obstacle;
	public GameObject boundary;
	public GameObject player;
	public GameObject ground;

	public Text scoreText;

	public int score;
	public string gameScene;
	public float spawnWait;
	private bool halt;
	private Vector2 obsPos = new Vector2(15f, -1.28f);
	private Vector2 groundPos = new Vector2(15f, 0f);

	void Start () {
		score = 0;
		scoreText.text = "Score: " + score.ToString();
		obstacle.GetComponent<Obstacle> ().setSpeed (-8f);
		StartCoroutine (Spawn ());
		halt = false;
	}
		
	IEnumerator Spawn () {
		while (true) {
			spawnWait = -20f / obstacle.GetComponent<Obstacle> ().getSpeed ();
			if (obstacle.GetComponent<Obstacle> ().getSpeed () > -30.0) {
				obstacle.GetComponent<Obstacle> ().changeSpeed (1.0f);
			}
			Instantiate (obstacle, obsPos, Quaternion.identity);
			Instantiate (ground, groundPos, Quaternion.identity);
			if (halt) {
				break;
			}
			yield return new WaitForSeconds (spawnWait);
		}
	}

	public void changeScore()
	{
		score++;
		scoreText.text = "Score: " + score.ToString();
	}

	public int getScore()
	{
		return score;
	}

	public void gameOver () {
		halt = true;
		SceneManager.LoadScene (gameScene);
	}
}
