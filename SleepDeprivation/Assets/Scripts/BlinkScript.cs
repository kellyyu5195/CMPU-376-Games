using UnityEngine;
using System.Collections;

public class BlinkScript : MonoBehaviour {

	Animator blinkAnim;
	int timer;
	int time = 300;

	void Start() {
		blinkAnim = GetComponent<Animator> ();
		timer = 0;
	}

	// Update is called once per frame
	void FixedUpdate () {
		timer++;
		if (timer % time == 0) {
			blinkAnim.SetTrigger("Blink");
		}
		blinkAnim.SetTrigger ("NoBlink");
		if (timer == 10 * time) {
			time =- 100;
		}
	}
}
