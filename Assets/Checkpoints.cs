using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour {

	[SerializeField] private Transform Player;
	[SerializeField] private Transform RespawnPoint;


	void OnTriggerEnter2D(Collider2D other){
		Player.transform.position = RespawnPoint.transform.position;
	}
}
