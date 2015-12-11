using UnityEngine;
using System.Collections;

public class Scripty : MonoBehaviour {
	public float range = 100.0f;
	
	Ray shootRay;
	int shootableMask;
	public string tag;
	public GameObject pair;
	public Camera thing;
	
	void Awake ()
	{
		shootableMask = LayerMask.GetMask ("Item");
	}
	
	
	void Update ()
	{	
		if (Input.GetButton ("Fire1")) {
			shootRay = thing.ScreenPointToRay (Input.mousePosition);
			RaycastHit shootHit;
			if (Physics.Raycast (shootRay, out shootHit, range, shootableMask)) {
				if (shootHit.collider.tag == tag) {
					Destroy(shootHit.transform.gameObject);
					pair.GetComponent<MeshRenderer>().enabled = true;
				}
			}
		}
	}
}
