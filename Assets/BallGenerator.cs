using UnityEngine;
using System.Collections;

public class BallGenerator : MonoBehaviour {
	public GameObject tmp;
	private float timeDelay;
	private float delta;
	private float randomX, randomY, randomZ;
	private float randXtarget, randZtarget;
	private int counter;
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
				timeDelay *= 0.8f;  
				counter = 0;
			}
		randomX = Random.Range (-2f, 2f);
		randomZ = Random.Range (15f, 30f);
		randomY = Random.Range (0.5f, 5f);
		randXtarget = Random.Range (-2f, 2f);
		randZtarget = Random.Range (0.5f, 2f);
		
		target = new Vector3(randXtarget, 1.2f, randZtarget);
		spawnpt = new Vector3(randomX,randomY,randomZ);
		direction = -(target - spawnpt);
			Debug.Log(direction);
		scaler = -2f / direction.z;

		GameObject Ball = (GameObject) Instantiate (tmp, spawnpt, transform.localRotation);
		Ball.GetComponent<Rigidbody>().velocity = direction*(-0.7f);
		 
		
		}
	}
}
