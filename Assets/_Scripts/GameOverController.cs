using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour {

	public Text finalScore;
	private int score;

	void Start ()
	{
		score = PlayerPrefs.GetInt ("FinalScore");
		if (score < 10) {
			finalScore.text = "Your score was " + score + ", better luck next time!";
		} else if (score >= 10 && score < 30) {
			finalScore.text = "Your score was " + score + ", great job!";
		} else {
			finalScore.text = "Your score was " + score + ", you are really good at this!";
		}
	}
}
