using UnityEngine;
using System.Collections;

public class incomeBall : MonoBehaviour {

	private float dt;
	private float TIMELIMIT = 10.0f;

	// Use this for initialization
	void Start () {
		dt = 0.0f;
		//gameObject.rigidbody.velocity = new Vector3 (0f, 0f, -3f);
	}
	
	// Update is called once per frame
	void Update () {
	
		dt += Time.deltaTime;
		if (dt >= TIMELIMIT) {
			Destroy (gameObject);
		}
	}
}
