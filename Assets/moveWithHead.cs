using UnityEngine;
using System.Collections;

public class moveWithHead : MonoBehaviour {

	public GameObject prefab;
	public GameObject head;
	public GameObject text;

	public int score, life; 
	private string scoretext;
	// Use this for initialization
	void Start () {
		head = GameObject.FindGameObjectWithTag ("headVR");
		//gameObject.transform.position = new Vector3 (0f, 1f, 1.5f);
		score = 0;
		life = 5;
	}

	private float rotationy;
	private float rotationx;

	// Update is called once per frame
	void Update () {
		//Debug.Log(head.transform.localRotation.y);
		//print (transform.localEulerAngles.y)
		//Debug.Log(head.transform.localEulerAngles.y);
		// scaling range : -1 to 1
		/*
		rotationy = (float)head.transform.localEulerAngles.y;
		rotationx = (float)head.transform.localEulerAngles.x;
		if (rotationx < 360 && rotationx > 320){
			gameObject.transform.position = new Vector3 (transform.position.x, (-(rotationx - 360f)/18f) + 1f, transform.position.z );
		}
		//else if (rotationx < 360 && rotationx > 320){
		//	gameObject.transform.position = new Vector3 (transform.position.x, (-(rotationx - 360f)/30f) + 1f, transform.position.z );
		//}

		if (rotationy > 0 && rotationy < 60) {
				gameObject.transform.position = new Vector3 ((rotationy / 60.0f)*2f, transform.position.y, transform.position.z);
		}
		else if (rotationy > 300 && rotationy < 360){
				gameObject.transform.position = new Vector3 (((rotationy - 360.0f))*2 / 60.0f, transform.position.y, transform.position.z);
		}*/

	}

	void OnCollisionEnter (Collision collision){
		Debug.Log ("lalalala");
		if (collision.collider.name == "leBall(Clone)"){
			score++;
			Debug.Log (score);
		}
		if (collision.collider.name == "grassball(Clone)"){
			Application.LoadLevel(1);
			score--;
			Debug.Log ("hit a grass bro");
		}
		scoretext = "Your Current Score: " + score;
		text.GetComponent<textController>().textChange(scoretext);
	}


}
