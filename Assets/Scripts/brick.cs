using UnityEngine;
using System.Collections;

public class brick : MonoBehaviour {
	public Sprite[] hitSprites;
	public static int breakableCount = 0;

	private int timesHit;
	private levelManager levelManager;
	private bool isBreakble;
	// Use this for initialization
	void Start () {
		isBreakble = (this.tag == "Breakable");
		if(isBreakble){
			breakableCount++;
		}
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<levelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter2D(Collision2D collision ){
		timesHit++;
		int maxHits = hitSprites.Length + 1;
		if (timesHit >= maxHits){
				breakableCount--;
				levelManager.BrickDestroyed();
				Destroy(gameObject);
			}
			else{
				LoadSprites();
			}
	}
	
	void LoadSprites(){
		int spriteIndex = timesHit - 1;
		this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
	}
}









