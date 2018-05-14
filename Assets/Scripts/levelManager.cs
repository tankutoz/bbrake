using UnityEngine;
using System.Collections;

public class levelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log("level load requested: "+ name);
		Application.LoadLevel(name);
	}
	
	public void QuitRequest(){
		Debug.Log("I want to quit");
		Application.Quit();
	}

	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	
	public void BrickDestroyed(){
		if(brick.breakableCount <= 0){
			LoadNextLevel();
		}
	}
}
