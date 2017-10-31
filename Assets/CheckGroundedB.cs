using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGroundedB : MonoBehaviour {

	private PlayerBearController player;

	// Use this for initialization
	void Start () {
		player = GetComponentInParent<PlayerBearController> ();

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
