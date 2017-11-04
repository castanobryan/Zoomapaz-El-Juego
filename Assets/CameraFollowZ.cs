using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowZ : MonoBehaviour {

	public GameObject followz;
	public Vector2 minCamPos, maxCamPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float posX = followz.transform.position.x;
		float posY = followz.transform.position.y;

		transform.position = new Vector3(Mathf.Clamp(posX,minCamPos.x,maxCamPos.x), Mathf.Clamp(posY,minCamPos.y,maxCamPos.y), transform.position.z);
	}
}
