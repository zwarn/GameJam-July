using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float acceleration;
	public float turnSpeed;
	public Color color;
	public float powerCharge = 5;
	public float powerSpend = 50;
	private Rigidbody2D rigidBody;
	private SpriteRenderer spriteRenderer;
	private float power;
	public bool powerMode = false;
	public bool dead = false;
	private GameObject goal;
	private float deadZone = 20;


	// Use this for initialization
	void Start () {
		goal = GameObject.FindGameObjectWithTag ("Goal");
		rigidBody = GetComponent<Rigidbody2D> ();
		spriteRenderer = GetComponentInChildren<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (dead) {
			spriteRenderer.color = new Color (0.5f, 0.5f, 0.5f);
		} else {
			spriteRenderer.color = new Color (1f, 1f, 1f);
		}
	}

	public void throttle (float throttle)
	{
		float factor = 4 - 3 * change () * rigidBody.velocity.magnitude / 100;
		rigidBody.AddForce (throttle * acceleration * transform.up * factor);
	}

	public void turn (float turn)
	{
		transform.RotateAround (transform.position, Vector3.forward, turn * turnSpeed);
	}

	public float change() {
		Vector2 v = rigidBody.velocity.normalized;
		Vector2 a = transform.up;
		float dot = Vector2.Dot (v, a);
		dot = Mathf.Max (dot,0);
		return dot;
	}

	public void addPower() {
		power += powerCharge * Time.deltaTime;
		power = Mathf.Min (100, power);
	}

	public float getPower() {
		return power;
	}

	public void enablePower (bool b)
	{
		if (b && power > 10) {
			powerMode = true;
		}
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.tag == "DeadZone") {
			dead = true;
		}
	}

	void OnTriggerExit2D(Collider2D coll) {
		if (coll.tag == "DeadZone") {
			dead = false;
		}
	}
		
}
