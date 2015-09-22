using UnityEngine;
using System.Collections;

public class PlayerNPCInteraction : MonoBehaviour {

	GameObject player;
	Animator anim;
	GameObject HUDCanvas;
	PlayerMovement playerMovement;
	PlayerAnxietyMeter playerAnxiety;
	float friendAmt;
	float anxietyAmt;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		HUDCanvas = GameObject.FindGameObjectWithTag ("HUDCanvas");
		playerMovement = player.GetComponent<PlayerMovement> ();
		anim = HUDCanvas.GetComponent<Animator> ();
		playerAnxiety = player.GetComponent<PlayerAnxietyMeter> ();
	}

	void FixedUpdate() {
		setAmts ();
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			playerMovement.enabled = false;
			anim.SetTrigger ("Interact");
		}
		playerMovement.enabled = true;
	}


	void setAmts() {
		if (Input.GetKey (KeyCode.C)) {
			friendAmt = 0f;
			anxietyAmt = 1f;
			anim.SetTrigger("Back");
			doSliderThings();
		} else {
			if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.B)) {
				friendAmt = Random.Range (0, 2) % 2;
				anim.SetTrigger ("Back");
				anxietyAmt = Random.Range (-1, 1);
				doSliderThings();
			} else {
				friendAmt = 0f;
				anxietyAmt = 0f;
			}
		}
	}

	void doSliderThings () {
		playerAnxiety.TakeFriends (friendAmt);
		playerAnxiety.TakeAnxiety (anxietyAmt);
	}

}
