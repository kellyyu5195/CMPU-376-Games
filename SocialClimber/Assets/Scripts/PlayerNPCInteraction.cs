using UnityEngine;
using System.Collections;

public class PlayerNPCInteraction : MonoBehaviour {

	private Animator anim;
	private GameObject HUDCanvas;
	private PlayerMovement playerMovement;
	private PlayerAnxietyMeter playerAnxiety;
	private KeyCode key;
	private float friendAmt;
	private float anxietyAmt;

	// Use this for initialization
	void Start () {
		HUDCanvas = GameObject.FindGameObjectWithTag ("HUDCanvas");
		playerMovement = GetComponent<PlayerMovement> ();
		anim = HUDCanvas.GetComponent<Animator> ();
		playerAnxiety = GetComponent<PlayerAnxietyMeter> ();
	}

	void Update() {
		setAmts ();
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "OtherStudent") {
			playerMovement.enabled = false;
			anim.SetTrigger ("Interact");
			playerAnxiety.TakeFriends (friendAmt);
			playerAnxiety.TakeAnxiety (anxietyAmt);
		}
		playerMovement.enabled = true;
	}


	void setAmts() {
		if (Input.GetKey (KeyCode.Alpha1)) {
			friendAmt = 0;
			anxietyAmt = 1;
			anim.SetTrigger ("Back");
			Debug.Log("blah");
		} else {
			if (Input.GetKey (KeyCode.Alpha2) || Input.GetKey (KeyCode.Alpha3)) {
				friendAmt = Random.Range (0, 10) % 2;
				anim.SetTrigger ("Back");
				anxietyAmt = 1;
			} else {
				friendAmt = 0;
				anxietyAmt = 0;
			}
		}
	}

}
