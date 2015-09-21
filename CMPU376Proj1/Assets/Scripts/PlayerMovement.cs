using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 1f;

	Rigidbody playerRB;
	float movement;

	// Use this for initialization
	void Start () {
		playerRB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0.0f);
		playerRB.velocity = movement * speed;
	}
}
