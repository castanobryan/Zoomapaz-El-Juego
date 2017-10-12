using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float maxSpeed = 5f;
	public float speed = 2f;
	public bool grounded;

	public Rigidbody2D rb2d;
	private Animator anim;


	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	void Update () {
		anim.SetFloat ("Speed", Mathf.Abs(rb2d.velocity.x));
		//anim.SetBool ("Grounded", grounded);
	}

	void FixedUpdate () {

		float h = Input.GetAxis ("Horizontal");

		rb2d.AddForce (Vector2.right * speed * h);

		float limitedSpeed = Mathf.Clamp (rb2d.velocity.x, -maxSpeed, maxSpeed);

		rb2d.velocity = new Vector2 (limitedSpeed, rb2d.velocity.y);

	}

}