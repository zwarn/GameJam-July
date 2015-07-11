using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private static GameController _instance;
	public static GameController get() {
		return _instance;
	}

	public GameObject ball;

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
}
