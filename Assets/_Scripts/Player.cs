using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameController gameController;
	private Rigidbody2D rb;
	public Collider2D player;
	public Collider2D ground;
	public float jumpForce;
	public float downForce;
	public float glideForce;
	bool keyUp = true;
	bool canJump = true;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}

	//Detects if player has touched "Ground" tag
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Ground") {
			canJump = true;
		}
	}
		
	void Update () {
		
		//Controls the player's jump, glide, and gravitational pull. 
		//CanJump is taken from OnCollisionEnter detecting if player has touched "Ground" tag
		if (Input.GetKeyDown(KeyCode.UpArrow) && keyUp == true && canJump == true)
		{
			rb.AddForce (transform.up * jumpForce, ForceMode2D.Impulse);
			keyUp = false;
			canJump = false;
		}
		if (Input.GetKey(KeyCode.UpArrow) && keyUp == false) 
		{
			rb.AddForce (transform.up * glideForce, ForceMode2D.Force);
		}
		if (Input.GetKeyUp (KeyCode.UpArrow)) 
		{
			keyUp = true;
		}
		else
		{
			rb.AddForce (transform.up * downForce);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Obstacle") {
			PlayerPrefs.SetInt ("FinalScore", gameController.GetComponent<GameController> ().getScore ());
			gameController.gameOver ();
		}
	}

}
