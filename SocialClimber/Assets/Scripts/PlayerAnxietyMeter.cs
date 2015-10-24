using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerAnxietyMeter : MonoBehaviour {

	public Slider anxietySlider;
	public Slider friendSlider;
	float startingAnxiety = 50f;
	float currentAnxiety;
	float startingFriends = 0f;
	float currentFriends;
	GameObject HUDCanvas;
	Animator anim;
	GameObject player;

	void Awake ()
	{
		HUDCanvas = GameObject.FindGameObjectWithTag ("HUDCanvas");
		anim = HUDCanvas.GetComponent<Animator> ();
		currentAnxiety = startingAnxiety;
		currentFriends = startingFriends;
	}

	public void Update() {
		if (currentAnxiety >= 100) {
			anim.SetTrigger ("GameObver");
			TakeAnxiety(-100);
		}
		if (currentFriends >= 100) {
			anim.SetTrigger ("Win");
			TakeAnxiety(-100);
		}
	}


	public void TakeAnxiety (float amount)
	{
		currentAnxiety += amount;
		anxietySlider.value = currentAnxiety;
	}

	public void TakeFriends (float amount)
	{
		currentFriends += amount;
		friendSlider.value = currentFriends;

	}
      
}
