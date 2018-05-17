using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	public LevelManager levelManeger;
	void OnTriggerEnter2D(Collider2D trigger){
		levelManeger.LoadLevel("Lose");
		
	}
	
	void OnCollisionEnter2D(Collision2D collision){
		print ("collision");
	}
}
