using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FuncionBotones : MonoBehaviour {

	public Button Boton;
	public Sprite Mute;
	public Sprite Unmute;
	private int cont= 0;

	void Start(){
		Boton = GetComponent<Button> ();
	}

	public void IniciarJuego(){
		SceneManager.LoadScene ("1W", LoadSceneMode.Single);
	}

	public void MutearTodo(){
		AudioListener.pause = !AudioListener.pause;
	}

	public void SwitchButton(){
		cont++;
		if (cont % 2 == 0) {
			Boton.image.overrideSprite = Mute;
		} else {
			Boton.image.overrideSprite = Unmute;
		}
	}
}
