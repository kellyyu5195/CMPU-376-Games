using UnityEngine;
using System.Collections;

public class PickUpScript : MonoBehaviour {

	public Health playerLove;

	// if you collide with an object called "PickUp",
	// destroy the game object
	void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.tag == "PickUp") {
			Destroy (other.gameObject);
			playerLove.pickUp = true;
		}
	}

}
