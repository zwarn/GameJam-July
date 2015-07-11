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
		rigidBody.AddForce (throttle * acceleration * transform.up);
	}

	public void turn (float turn)
	{
		transform.RotateAround (transform.position, Vector3.forward, turn * turnSpeed);
	}
}
