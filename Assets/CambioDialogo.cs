using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDialogo : MonoBehaviour {

	
	public void Dialogos(string Scene){
		SceneManager.LoadScene ((Scene), LoadSceneMode.Single);

		}

	}



