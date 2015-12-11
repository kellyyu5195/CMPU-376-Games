using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {

	// private fields
	GameObject player;
	Transform objTrans;

	//public fields
	public Vector3 destination;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		objTrans = this.transform;
	}

	void OnTriggerEnter(Collider coll) {
		GameObject obj = coll.gameObject;
		if (obj == player) {
			objTrans.position = destination;
		}
	}
}
