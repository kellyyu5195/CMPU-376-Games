using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	int love;
	public bool pickUp;
	int timer;
	public Animator heartAnim;
	GameObject boy;
	GameObject mom;
	MomMovement momMove;
	MomShooting momShoot;
	Transform momTransform;
	GameObject player;
	Rigidbody2D playerRB;
	CharacterMovement playerMove;


	// Use this for initialization
	void Start () {
		love = 3;
		pickUp = false;
		timer = 0;

		boy = GameObject.FindGameObjectWithTag ("boy");
		mom = GameObject.FindGameObjectWithTag ("mom");
		momTransform = mom.GetComponent<Transform> ();
		momMove = mom.GetComponent<MomMovement> ();
		momShoot = mom.GetComponent<MomShooting> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		playerRB = player.GetComponent<Rigidbody2D> ();
		playerMove = player.GetComponent<CharacterMovement> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (timer == 0) {
			if (love == 0) {
				Destroy (boy.gameObject);
				Destroy (this.gameObject);
				momTransform.position = player.transform.position;
				playerRB.velocity= new Vector2 (0,0);
				momMove.enabled = false;
				playerMove.enabled = false;
			}
		}

		timer ++;

		if (pickUp) {
			love ++;
			pickUp = false;
			heartAnim.SetInteger ("UpOrDown", love);
		}

		if (timer == 300) {
			love --;
			timer = 0;				
			heartAnim.SetInteger("UpOrDown", -1);

		}
	}

}

