using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	int love;
	public bool pickUp;
	int timer;

	// Use this for initialization
	void Start () {
		love = 10;
		pickUp = false;
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer ++;
		if (pickUp) {
			love ++;
			pickUp = false;
		} else {
			if (timer == 100) {
				love --;
				timer = 0;
			}
		}
	}
}
