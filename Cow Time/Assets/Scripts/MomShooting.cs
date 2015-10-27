using UnityEngine;
using System.Collections;

public class MomShooting : MonoBehaviour {

	public GameObject bullet;
	int timer = 0;
	Transform transform;

	void Start() {
		transform = GetComponent<Transform> ();
	}

	void Update() {
		timer++;
		if (timer == 500) {
			Instantiate(bullet, transform.position, Quaternion.identity);
			timer = 0;
		}
	}

}
