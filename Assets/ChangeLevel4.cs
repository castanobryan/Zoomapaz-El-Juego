using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel4 : MonoBehaviour {
	
		void OnTriggerEnter2D(Collider2D other){
			if(other.gameObject.tag == "Player"){
				SceneManager.LoadScene ("5W", LoadSceneMode.Single);
			}
		}
}
