using UnityEngine;
using System.Collections;

public class Sounds : MonoBehaviour {
	
	public AudioClip groan;
	public AudioClip goToSleep;
	// Use this for initialization
	IEnumerator Start () {
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
		yield return new WaitForSeconds(audio.clip.length);
		audio.clip = groan;
		audio.Play();
		yield return new WaitForSeconds(audio.clip.length);
		audio.clip = goToSleep;
		audio.Play();
	}
}
