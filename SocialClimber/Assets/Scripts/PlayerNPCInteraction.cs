using UnityEngine;
using System.Collections;

public class PlayerNPCInteraction : MonoBehaviour {

	GameObject player;
	Animator anim;
	GameObject HUDCanvas;
	PlayerMovement playerMovement;
	PlayerAnxietyMeter playerAnxiety;
	int thing;
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
			doSliderThings();
		}
		playerMovement.enabled = true;
	}


	void setAmts() {
		if (Input.GetKey (KeyCode.C)) {
			thing = 0;
		} else {
			if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.B)) {
				thing = 1;
			} else {
				thing = 2;
			}
		}
	}

	void doSliderThings () {
		switch (thing) {
		case 0:
			friendAmt = 0f;
			anxietyAmt = 1f;
			break;
		case 1:
			friendAmt = Random.Range (0, 1);
			anxietyAmt = Random.Range (-1, 1);
			break;
		case 2:
			friendAmt = 0f;
			anxietyAmt = 0f;
			break;
		}
		playerAnxiety.TakeFriends (friendAmt);
		playerAnxiety.TakeAnxiety (anxietyAmt);
	}

}
