using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float acceleration;
	public float turnSpeed;
	public Color color;
	public float powerCharge = 5;
	public float powerSpend = 50;
	private Rigidbody2D rigidBody;
	private float power;
	public bool powerMode = false;
	public bool dead = false;


	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
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
}
