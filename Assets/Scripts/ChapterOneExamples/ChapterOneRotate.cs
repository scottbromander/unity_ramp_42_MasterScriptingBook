﻿using UnityEngine;
using System.Collections;

public class ChapterOneRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0.0f, 2.0f, 0.0f));
	}
}
