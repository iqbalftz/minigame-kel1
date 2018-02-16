using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	private float score;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(Input.GetAxis("Horizontal"),0,0);
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Sphere(Clone)")
		{
			score++;
			Destroy(col.gameObject);
			Debug.Log(score);
		}
	}

}
