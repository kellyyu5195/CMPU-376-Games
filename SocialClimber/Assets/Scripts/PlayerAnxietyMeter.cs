using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerAnxietyMeter : MonoBehaviour {

	public float startingAnxiety;
	public float currentAnxiety;
	public float startingFriends;
	public float currentFriends;
	public Slider anxietySlider;
	public Slider friendSlider;

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
