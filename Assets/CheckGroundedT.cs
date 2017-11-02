using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGroundedT : MonoBehaviour {

	private PlayerTigController player;

	// Use this for initialization
	void Start () {
		player = GetComponentInParent<PlayerTigController> ();

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
