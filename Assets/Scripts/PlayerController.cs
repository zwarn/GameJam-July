using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float acceleration;
	public float turnSpeed;
	public Color color;
	private Rigidbody2D rigidBody;


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
}
