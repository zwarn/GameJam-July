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
			owner = coll.gameObject.GetComponent<PlayerController>();
			renderer.color = owner.color;
		}
	}
}
