using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {
	
	IEnumerator Start () {
		AudioSource audio = GetComponent<AudioSource> ();
		yield return new WaitForSeconds (audio.clip.length);
		Application.LoadLevel(2);
	}
}
