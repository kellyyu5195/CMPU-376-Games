using UnityEngine;
using System.Collections;

public class BlinkScript : MonoBehaviour {

	Animator blinkAnim;
	int timer;
	int time = 400;


	void Start() {
		blinkAnim = GetComponent<Animator> ();
		timer = 0;
	}

	// Update is called once per frame
	void FixedUpdate () {
		timer++;
		if (timer % time == 0 && timer > time) {
			blinkAnim.SetTrigger("Blink");
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
		}
		blinkAnim.SetTrigger ("NoBlink");
		if (timer == 10 * time) {
			time =- 100;
		}
	}
}
