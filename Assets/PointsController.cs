using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsController : MonoBehaviour {


	private int points = 0;
	public Text pointsText;

	void Awake (){
		DontDestroyOnLoad (gameObject);
	}

	void Start () {
		
	}
		
	void Update () {
		
	}

	public void IncreasePoints(){
		points = points + 100;
		pointsText.text = points.ToString ();
	}

	public void DecreasePoints(){
		if (points > 0) {
			points = points - 50;
			pointsText.text = points.ToString ();
		} 
		if (points == 0) { 
			points = points + 0;
			pointsText.text = points.ToString ();
		}
	}
}
