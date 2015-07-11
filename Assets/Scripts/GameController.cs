using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	private static GameController _instance;
	public static GameController get() {
		return _instance;
	}

	public GameObject ball;
	private Dictionary<PlayerController, int> scoreMap = new Dictionary<PlayerController, int>();


	void Awake() {
		if (_instance == null) {
			_instance = this;
		} else {
			Destroy(this);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void reSpawn() {
		Instantiate (ball, Vector3.zero, Quaternion.identity);
	}

	public void score(PlayerController playerController) {
		Debug.Log ("Score " + playerController);
		if (scoreMap.ContainsKey (playerController)) {
			scoreMap [playerController] += 1;
		} else {
			scoreMap [playerController] = 1;
		}
	}

	public int getScore (PlayerController player)
	{
		if (scoreMap.ContainsKey(player)) {
			return scoreMap[player];
		} else return 0;
	}
}
