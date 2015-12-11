using UnityEngine;
using System.Collections;

public class Sounds2 : MonoBehaviour {

	public AudioClip blah;
	// Use this for initialization
	IEnumerator Start () {
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play ();
		yield return new WaitForSeconds (audio.clip.length);
		audio.clip = blah;
		audio.Play ();
	}
}
