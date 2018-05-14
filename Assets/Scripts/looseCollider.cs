using UnityEngine;
using System.Collections;

public class looseCollider : MonoBehaviour {
	
	private levelManager levelManager;
	
	void OnTriggerEnter2D(Collider2D trigger){
		levelManager = GameObject.FindObjectOfType<levelManager>();
		levelManager.LoadLevel("lose");
	}
	
	void OnCollisionEnter2D(Collision2D collision ){
		print ("Collision");
	}

}
