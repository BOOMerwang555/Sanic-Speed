using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (PlayerPrefs.GetFloat ("Speed") * Time.deltaTime, 0, 0);
		Destroy (gameObject, 3.5f);
	}
}
