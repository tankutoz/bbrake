using UnityEngine;
using System.Collections;

public class musicPlayer : MonoBehaviour {
	static musicPlayer instance = null;
	// Use this for initialization
	void Start () {
	if (instance != null){
		Destroy(gameObject);
	}else {
		instance = this;
		GameObject.DontDestroyOnLoad(gameObject);
	}	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
