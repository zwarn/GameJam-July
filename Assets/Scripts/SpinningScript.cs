using UnityEngine;
using System.Collections;

public class SpinningScript : MonoBehaviour {

	public float turnSpeed = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (transform.position, Vector3.forward, turnSpeed);
	}
}
