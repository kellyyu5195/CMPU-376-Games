using UnityEngine;
using System.Collections;

public class Fin : MonoBehaviour {

	public int count = 0;
	public int sceneNum;
	
	void Update() {
		if (count == 5) {
			Application.LoadLevel (sceneNum);
		}
	}
}
