using UnityEngine;
using System.Collections;

/*
MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAvevuqsE1V5/Ak7GgBdARxkpVlwqsLtxkz4iQfCV1MQNhXz/4rhCVJOh1rURUp2yxU9qt/Sg4v0+Wx27cgGVKdcES3utZjgx/I5zCEIQ8qFueFr73AbW1mYeqaBpUQv17b00ajZw/XwfhxViQrE4UlsM6TlpVvth8XsIzgod9UJ2eO2fYb56fad/FbhLVs9cZVftZPANAKqad6IZlGgtN1LLk0nQZU0Q+MDVkRbLFe8I9pknMl6U1/zefsJiWdBR1KH5GhqXztlRC54nTqahdPMDK6256SNVL/YXP2C0so/izGkPFfm6WjHHTLuAr13ztewAGbYAvwwwBXf2lx93YQQIDAQAB
 */
public class BallGenerator : MonoBehaviour {
	public GameObject tmp;
	public GameObject william;
	private float timeDelay;
	private float delta;
	private float randomX, randomY, randomZ;
	private float randXtarget, randYtarget, randZtarget;
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
			randomX = Random.Range (-16f, 16f);
			randomZ = Random.Range (15f, 30f);
			randomY = Random.Range (0.5f, 10f);
			randXtarget = Random.Range (-1.3f, 1.3f);
			randYtarget = Random.Range (0.5f, 2f);
			
			target = new Vector3(randXtarget, randYtarget, 0.5f);
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
