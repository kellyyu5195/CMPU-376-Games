using UnityEngine;
using System.Collections;

public class BulletBehavior : MonoBehaviour {

	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2(10, 0);
	}

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "heart") {
			Destroy (col.gameObject);
		}
	}
}
