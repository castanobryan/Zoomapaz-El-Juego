using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckpointActivate : MonoBehaviour {
	public Image Check;
	public Sprite NoCheckpoint;
	public Sprite Checkpoint;
	private int contcheck = 0;

	void Start (){
		Check = GameObject.Find ("").GetComponent<Image> ();
	}

	void OnTriggerEnter2D(Collider2D other){
		contcheck++;
		if(contcheck % 2 == 0){
			
		}
	}
}
