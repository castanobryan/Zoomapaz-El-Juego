using UnityEngine;
using System.Collections;

public class Checkpoint1 : MonoBehaviour {

	public Vector3 inicio;
	public Vector3 check1;


	void Awake()
	{

		if (PlayerPrefs.GetInt("Checkpoint1") == 1)
		{
			this.transform.position = check1;
		}
	}

	void Start () {

	}
		
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "check1")
		{

			PlayerPrefs.SetInt("Checkpoints", 1);
		}

		if (other.gameObject.tag == "Respawn")
		{

			if (PlayerPrefs.GetInt("Checkpoints") == 0)
			{
				this.transform.position = inicio;
			}


			if (PlayerPrefs.GetInt("Checkpoints") == 1)
			{
				this.transform.position = check1;
			}
		}
	}
}