using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public static int breakableCount = 0;

	public int maxHits;
	
	private int timesHit;
	
	private LevelManager levelManager;
	private bool isBreakable;
	
	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "Breakable");
		if (isBreakable) {
			breakableCount++;
		}
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter2D (Collision2D col) {
		timesHit++;
		if (timesHit >= maxHits) {
			breakableCount--;
			Destroy(gameObject);
		}
	}
	void SimulateWin () {
		levelManager.LoadNextLevel();
	}
}
