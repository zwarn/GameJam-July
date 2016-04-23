using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {

	public PlayerController playerController1;
	public PlayerController playerController2;
	public PlayerController playerController3;
	public PlayerController playerController4;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float throttle1 = Mathf.Max(0,Input.GetAxis ("Throttle1"));
		playerController1.enablePower (Input.GetAxis ("Throttle1") < 0);
		playerController1.throttle (throttle1);

		float throttle2 = Mathf.Max(0,Input.GetAxis ("Throttle2"));
		playerController2.throttle (throttle2);

		float throttle3 = Mathf.Max(0,Input.GetAxis ("Throttle3"));
		playerController3.throttle (throttle3);

		float throttle4 = Mathf.Max(0,Input.GetAxis ("Throttle4"));
		playerController4.throttle (throttle4);

		float turn1 = -Input.GetAxis ("Turn1");
		playerController1.turn (turn1);

		float turn2 = -Input.GetAxis ("Turn2");
		playerController2.turn (turn2);

		float turn3 = -Input.GetAxis ("Turn3");
		playerController3.turn (turn3);

		float turn4 = -Input.GetAxis ("Turn4");
		playerController4.turn (turn4);
	}
}
