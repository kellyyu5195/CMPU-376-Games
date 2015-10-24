using UnityEngine;
using System.Collections;

public class PlayerNPCInteraction : MonoBehaviour {

	GameObject player;
	Animator anim;
	GameObject HUDCanvas;
	PlayerMovement playerMovement;
	PlayerAnxietyMeter playerAnxiety;
	float friendAmt;

	
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
		if (Input.GetKey (KeyCode.C)) {
			playerAnxiety.TakeFriends (0);
			anim.SetTrigger ("Back");
			Debug.Log ("thing");
		} else {
			if (Input.GetKey (KeyCode.A)) {
				playerAnxiety.TakeFriends (1f);
				playerAnxiety.TakeAnxiety (-0.1f);
				anim.SetTrigger ("Back");
			} else if (Input.GetKey (KeyCode.B)) {
				playerAnxiety.TakeFriends (0f);
				playerAnxiety.TakeAnxiety (0.1f);
				anim.SetTrigger ("Back");

			} else {
				playerAnxiety.TakeFriends (0);
			}
		}
	}


	
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			playerMovement.enabled = false;
			anim.SetTrigger ("Interact");
		}
		playerMovement.enabled = true;
	}

}
