using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {

	public PlayerController playerController1;
	public PlayerController playerController2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float throttle1 = Mathf.Max(0,Input.GetAxis ("Throttle1"));
		playerController1.throttle (throttle1);

		float throttle2 = Mathf.Max(0,Input.GetAxis ("Throttle2"));
		playerController2.throttle (throttle2);

		float turn1 = -Input.GetAxis ("Turn1");
		playerController1.turn (turn1);

		float turn2 = -Input.GetAxis ("Turn2");
		playerController2.turn (turn2);
	}
}
