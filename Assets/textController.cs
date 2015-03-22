using UnityEngine;
using System.Collections;

public class textController : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		textChange ("hello world");
	}

	public void textChange(string str){

		gameObject.GetComponent<TextMesh> ().text = str;
	}

}
