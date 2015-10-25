using UnityEngine;
using System.Collections;

public class PickUpScript : MonoBehaviour {

	// if you collide with an object called "PickUp",
	// destroy the game object
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			Destroy (this.gameObject);
		}
	}

}
