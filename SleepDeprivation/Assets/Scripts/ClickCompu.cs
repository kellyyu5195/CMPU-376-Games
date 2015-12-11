using UnityEngine;
using System.Collections;

public class ClickCompu : MonoBehaviour {
	
	public float range = 10000.0f;
	
	Ray shootRay;
	int shootableMask;
	float smallDiff = 0.01f;
	Animator anim;
	public Canvas HUDCanvas;
	
	void Awake ()
	{
		shootableMask = LayerMask.GetMask ("Shootable");
		anim = HUDCanvas.GetComponent<Animator> ();
	}
	
	
	void FixedUpdate ()
	{	
		if (Input.GetButton ("Fire1")) {
			shootRay = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit shootHit;
			if (Physics.Raycast (shootRay, out shootHit, range, shootableMask)) {
				if (shootHit.collider.tag == "Screen") {
					anim.SetTrigger("Ins");
				}
			}
		}
		if (Input.GetKey (KeyCode.Alpha0)) {
			anim.SetTrigger ("Back");
		}
	}
}
