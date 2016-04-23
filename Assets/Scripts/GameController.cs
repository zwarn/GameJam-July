using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	private static GameController _instance;
	public static GameController get() {
		return _instance;
	}

	public List<GameObject> spawnPoints;
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
		reSpawn ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void reSpawn() {
		Vector3 pos = spawnPoints[Random.Range(0, spawnPoints.Count)].transform.position;
		Instantiate (ball, pos, Quaternion.identity);
	}

	public void score(PlayerController playerController) {
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
