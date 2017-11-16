using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel5 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Player"){
			SceneManager.LoadScene ("Zari16", LoadSceneMode.Single);
		}
	}
}
