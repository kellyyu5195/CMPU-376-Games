using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerAnxietyMeter : MonoBehaviour {

	public Slider anxietySlider;
	public Slider friendSlider;
	float startingAnxiety = 5f;
	float currentAnxiety;
	float startingFriends = 0f;
	float currentFriends;


	void Awake ()
	{
		currentAnxiety = startingAnxiety;
		currentFriends = startingFriends;
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
