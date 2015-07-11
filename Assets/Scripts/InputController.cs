using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {

	public PlayerController playerController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float throttle = Mathf.Max(0,Input.GetAxis ("Horizontal"));
		playerController.throttle (throttle);
		float turn = Input.GetAxis ("Vertical");
		playerController.turn (turn);
	}
}
