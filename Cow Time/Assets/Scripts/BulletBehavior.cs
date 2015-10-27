using UnityEngine;
using System.Collections;

public class BulletBehavior : MonoBehaviour {

	public GameObject milkyWay;

	Rigidbody2D rb;
	GameObject heart;
	GameObject mom;
	Transform momTransform;
	GameObject player;
	Transform playerTransform;
	MomMovement momMovement;
	CharacterMovement charMove;
	MomShooting momShooting;
	Rigidbody2D playerRB;
	GameObject boy;
	Transform boyTrans;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2(10, 0);

		heart = GameObject.FindGameObjectWithTag ("heart");

		mom = GameObject.FindGameObjectWithTag ("mom");
		momTransform = mom.GetComponent<Transform> ();
		momShooting = mom.GetComponent<MomShooting> ();

		player = GameObject.FindGameObjectWithTag ("Player");
		playerTransform = player.GetComponent<Transform> ();
		charMove = player.GetComponent<CharacterMovement> ();
		playerRB = player.GetComponent<Rigidbody2D> ();

		boy = GameObject.FindGameObjectWithTag ("boy");
		boyTrans = boy.GetComponent<Transform> ();
	}

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "Player") {
			Destroy (heart);
			Destroy (this.gameObject);
			playerRB.velocity = new Vector2 (0, 0);
			charMove.enabled = false;
			momShooting.enabled = false;
			Vector2 milkyWayLoc = new Vector2(playerTransform.position.x, playerTransform.position.y - 2);
			Instantiate (milkyWay, milkyWayLoc, Quaternion.identity);
			boyTrans.position = new Vector2 (boyTrans.position.x, boyTrans.position.y - 5);
		}

		if (col.gameObject.tag == "Wall" || col.gameObject.tag == "PickUp") {
			Destroy (this.gameObject);
		}
	}
}
