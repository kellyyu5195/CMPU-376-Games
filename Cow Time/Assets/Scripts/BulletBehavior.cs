using UnityEngine;
using System.Collections;

public class BulletBehavior : MonoBehaviour {

	Rigidbody2D rb;
	GameObject heart;
	GameObject boy;
	GameObject mom;
	Transform momTransform;
	GameObject player;
	Transform playerTransform;
	MomMovement momMovement;
	CharacterMovement charMove;
	MomShooting momShooting;
	Rigidbody2D playerRB;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2(10, 0);

		heart = GameObject.FindGameObjectWithTag ("heart");
		boy = GameObject.FindGameObjectWithTag ("boy");

		mom = GameObject.FindGameObjectWithTag ("mom");
		momTransform = mom.GetComponent<Transform> ();
		momMovement = mom.GetComponent<MomMovement> ();
		momShooting = mom.GetComponent<MomShooting> ();

		player = GameObject.FindGameObjectWithTag ("Player");
		playerTransform = player.GetComponent<Transform> ();
		charMove = player.GetComponent<CharacterMovement> ();
	}

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "Player") {
			Destroy (heart);
			Destroy (boy);
			Destroy (this.gameObject);
			momTransform.position = playerTransform.position;
			momMovement.enabled = false;
			charMove.enabled = false;
			momShooting.enabled = false;
		}
	}
}
