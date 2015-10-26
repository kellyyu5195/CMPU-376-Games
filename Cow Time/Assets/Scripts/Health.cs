using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	int love;
	public bool pickUp;
	int timer;
	public Animator heartAnim;

	// Use this for initialization
	void Start () {
		love = 3;
		pickUp = false;
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer ++;
		if (pickUp) {
			love ++;
			pickUp = false;
			Debug.Log(love);
			heartAnim.SetInteger("Int1", love);
		} else {
			if (timer == 10000) {
				love --;
				timer = 0;
				Debug.Log(love);
			}
		}
	}
}
