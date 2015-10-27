using UnityEngine;
using System.Collections;

public class MomMovement : MonoBehaviour {

	public float speed;
	public GameObject player;
	
	float movement;
	Transform playerTransform;
	Transform momTransform;

	// Use this for initialization
	void Start () {
		playerTransform = player.GetComponent<Transform> ();
		momTransform = GetComponent<Transform> ();
		speed = 0.05f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 playerPos = playerTransform.position;
		Vector3 targ = new Vector3 (playerPos.x - 15, playerPos.y, playerPos.z);
		momTransform.position = Vector3.MoveTowards(momTransform.position, targ, speed);
	}
}
