using UnityEngine;
using System.Collections;

public class NPCZone : MonoBehaviour {

	GameObject player;
	Animator anim;
	PlayerAnxietyMeter playerAnxiety;
	float anxietyAmt;
	
	
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerAnxiety = player.GetComponent<PlayerAnxietyMeter> ();
	}

	void OnTriggerStay (Collider other) {
		if (other.tag == "Player") {
			playerAnxiety.TakeAnxiety(0.1f);
		}
	}

	void OnTriggerExit (Collider other) {
		if (other.tag == "Player") {
			playerAnxiety.TakeAnxiety (-10f);
		}
	}

}
