using UnityEngine;
using System.Collections;

public class CamSwitch : MonoBehaviour {
	
	//public fields
	public Camera playerCam;
	public Camera tableCam;

	
	// Use this for initialization
	void Start () {
		playerCam.enabled = true;
		tableCam.enabled = false;
	}
	
	void OnTriggerEnter(Collider coll) {
		GameObject obj = coll.gameObject;
		if (obj.gameObject.tag == "Player") {
			playerCam.enabled = false;
			tableCam.enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) {
			playerCam.enabled = true;
			tableCam.enabled = false;
		}
	}
}
