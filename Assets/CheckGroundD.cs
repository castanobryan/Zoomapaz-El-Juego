using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGroundD : MonoBehaviour {

	private PlayerDacController player;

	// Use this for initialization
	void Start () {
		player = GetComponentInParent<PlayerDacController> ();

	}

	void OnCollisionStay2D(Collision2D col){
		if (col.gameObject.tag == "Ground") {
			player.grounded = true;
		}
	}
	void OnCollisionExit2D(Collision2D col){
		if (col.gameObject.tag == "Ground") {
			player.grounded = false;
		}

	}
}
