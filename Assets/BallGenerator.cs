using UnityEngine;
using System.Collections;

public class BallGenerator : MonoBehaviour {
	public GameObject tmp;
	public GameObject william;
	private float timeDelay;
	private float delta;
	private float randomX, randomY, randomZ;
	private float randXtarget, randZtarget;
	private int counter, randChoose;
	private new Vector3 target, direction, spawnpt;
	private float scaler;


	// Use this for initialization
	void Start () {
		timeDelay = 2f;
		delta = 0f;
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {

		delta += Time.deltaTime;

		if (delta >= timeDelay) {
				//do things here 
				delta = 0f;
				counter ++;
				if (counter == 7){
					timeDelay *= 0.9f;  
					counter = 0;
				}
			randomX = Random.Range (-20f, 20f);
			randomZ = Random.Range (15f, 30f);
			randomY = Random.Range (0.5f, 15f);
			randXtarget = Random.Range (-1.3f, 1.3f);
			randZtarget = Random.Range (0.5f, 2f);
			
			target = new Vector3(randXtarget, 1.2f, randZtarget);
			spawnpt = new Vector3(randomX,randomY,randomZ);
			direction = spawnpt - target;
				Debug.Log(direction);
			scaler = -2f / direction.z;

			randChoose = Random.Range (1,5);
			if (randChoose == 2){
					GameObject Bomb = (GameObject) Instantiate (william, spawnpt, transform.localRotation);
					Bomb.GetComponent<Rigidbody>().velocity = direction*(-0.7f);
			}
			else{
				GameObject Ball = (GameObject) Instantiate (tmp, spawnpt, transform.localRotation);
				Ball.GetComponent<Rigidbody>().velocity = direction*(-0.7f);
			} 
			
		}
	}
}
