using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {
	private paddle paddle;
	private Vector3 paddleToBallVec;
	private bool hasStarted = false;
	void Start () {
	paddle = GameObject.FindObjectOfType<paddle>();
		paddleToBallVec = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted){
			this.transform.position = paddle.transform.position + paddleToBallVec;
			if (Input.GetMouseButtonDown(0)){
				hasStarted = true;
				this.rigidbody2D.velocity = new Vector2 (2f,10f);
			}
		}
	}
}
