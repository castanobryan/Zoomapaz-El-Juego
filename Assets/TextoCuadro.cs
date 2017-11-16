using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoCuadro : MonoBehaviour {

	public string contenido = "";
	public Text texto;
	// Use this for initialization
	void Start () {
		StartCoroutine (LaL(contenido));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator LaL(string txt){
		int letra = 0;
		texto.text = "";
		while (letra < txt.Length) {
			texto.text += txt[letra];
			letra += 1;
			yield return new WaitForSeconds (0.05f);
		}
	}
}
