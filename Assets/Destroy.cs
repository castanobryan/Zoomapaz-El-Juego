using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	public GameObject game;
	// Use this for initialization
	void Start () {
		game = GameObject.Find ("Points");
		if (game != null) {
			Destroy (game);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
