using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {

	// private fields
	Transform playerTrans;

	//public fields
	public Camera playerCam;
	public Camera tableCam;

	// Use this for initialization
	void Start () {
		playerTrans = GetComponent<Transform> ();
		playerCam.enabled = true;
		tableCam.enabled = false;
	}

	void OnTriggerEnter(Collision coll) {
		GameObject obj = coll.gameObject;
//		SupplyInfo info = obj.GetComponent<SupplyInfo>;
		Transform objTrans = coll.gameObject.transform;
		if (obj.tag == "PickUp") {
			playerCam.enabled = false;
			tableCam.enabled = true;
			playerTrans.position = new Vector3 (0, 0, 0);
//			objTrans.position = SupplyInfo.loc;
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
