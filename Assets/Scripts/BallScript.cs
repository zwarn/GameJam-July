using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	PlayerController owner;
	SpriteRenderer renderer;

	// Use this for initialization
	void Start () {
		renderer = transform.GetComponentInChildren<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (owner != null) {
			owner.addPower();
		}
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Goal") {
			Destroy(gameObject);
			GameController gameController = GameController.get();
			gameController.score(owner);
			gameController.reSpawn();
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player") {
			PlayerController playerController = coll.gameObject.GetComponent<PlayerController>();

			if (owner == null || !playerController.dead) {
				owner = playerController;
				renderer.color = owner.color;
			}
		}
	}
}
