using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {

	// private fields
	GameObject player;
	Transform objTrans;
	public GameObject pair;
	public GameObject gameCont;
	Fin fin;

	//public fields
	public Vector3 destination;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		objTrans = this.transform;
		fin = gameCont.GetComponent<Fin> ();
	}

	void OnTriggerEnter(Collider coll) {
		GameObject obj = coll.gameObject;
		if (obj == player) {
			objTrans.position = destination;
			fin.count ++;
			pair.GetComponent<MeshRenderer>().enabled = true;
			Destroy(this.gameObject);
		}
	}
}
