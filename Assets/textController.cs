using UnityEngine;
using System.Collections;

public class textController : MonoBehaviour {

	private float dt;
	private string tmp;

	// Use this for initialization
	void Start () {
		
		dt = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		dt += Time.deltaTime;
		tmp = "";
		tmp += dt;
		textChange (tmp);
	}

	public void textChange(string str){

		gameObject.GetComponent<TextMesh> ().text = str;
	}

}
