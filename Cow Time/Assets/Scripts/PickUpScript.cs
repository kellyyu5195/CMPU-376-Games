using UnityEngine;
using System.Collections;

public class PickUpScript : MonoBehaviour {
	
	void Start () {
	}
	
	void OnTriggerEnter (Collider other) {
		if (other.tag == "PickUp") {
			Destroy (other);
		}
	}

}
