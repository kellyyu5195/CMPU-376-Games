using UnityEngine;
using System.Collections;

public class PlayerNPCInteraction : MonoBehaviour {

	GameObject player;
	Animator anim;
	GameObject HUDCanvas;
	PlayerMovement playerMovement;
	PlayerAnxietyMeter playerAnxiety;
//	int thing;
	float friendAmt;
	float anxietyAmt;
	bool blah;
	
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		HUDCanvas = GameObject.FindGameObjectWithTag ("HUDCanvas");
		playerMovement = player.GetComponent<PlayerMovement> ();
		anim = HUDCanvas.GetComponent<Animator> ();
		playerAnxiety = player.GetComponent<PlayerAnxietyMeter> ();
	}

	void Update() {
		setAmts ();
	}

	void setAmts() {
//		if (blah) {
			if (Input.GetKey (KeyCode.C)) {
				playerAnxiety.TakeAnxiety (1);
				playerAnxiety.TakeFriends (0);
				anim.SetTrigger ("Back");
				Debug.Log ("thing");
//				blah = false;
			} else {
				if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.B)) {
					playerAnxiety.TakeAnxiety (Random.Range (-1, 1));
					playerAnxiety.TakeFriends (Random.Range (0, 1));
					anim.SetTrigger ("Back");
//					blah = false;
				} else {
					playerAnxiety.TakeAnxiety (0);
					playerAnxiety.TakeFriends (0);
//					blah = false;
				}
			}
		}
//	}

	
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			playerMovement.enabled = false;
			anim.SetTrigger ("Interact");
//			doSliderThings();
			blah = true;
		}
		playerMovement.enabled = true;
	}

//	void doSliderThings () {
////		switch (thing) {
////		case 0:
////			friendAmt = 0f;
////			anxietyAmt = 1f;
////			break;
////		case 1:
////			friendAmt = Random.Range (0, 1);
////			anxietyAmt = Random.Range (-1, 1);
////			anim.SetTrigger("Back");
////			break;
////		case 2:
////			friendAmt = 0f;
////			anxietyAmt = 0f;
////			break;
////		}
//		playerAnxiety.TakeFriends (friendAmt);
//		playerAnxiety.TakeAnxiety (anxietyAmt);
//	}

}
