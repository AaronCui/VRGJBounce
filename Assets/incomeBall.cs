﻿using UnityEngine;
using System.Collections;

public class incomeBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.rigidbody.velocity = new Vector3 (0f, 0f, -3f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
