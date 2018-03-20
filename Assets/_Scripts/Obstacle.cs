using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
	
	public float speed;
	private GameObject gameController;

	void Start () {
		gameController = GameObject.Find("Game Controller");
		gameObject.GetComponent<SpriteRenderer>().material.SetColor("_Color", Random.ColorHSV(0f, 1f, 0.5f, 1f));
		transform.localScale += new Vector3 (0, Random.value , 0);
	}
	
	void Update () {
		PlayerPrefs.SetFloat ("Speed", speed);
		transform.Translate (speed * Time.deltaTime, 0, 0);
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.tag == "Boundary") {
			gameController.GetComponent<GameController> ().changeScore ();
			Destroy(gameObject);
		}
	}

	public void changeSpeed (float newSpeed)
	{
		speed -= newSpeed;
	}

	public void setSpeed (float newSpeed)
	{
		speed = newSpeed;
	}

	public float getSpeed ()
	{
		return speed;
	}
}
