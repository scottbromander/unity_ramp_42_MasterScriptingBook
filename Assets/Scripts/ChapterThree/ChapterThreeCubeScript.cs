using UnityEngine;
using System.Collections;

public class ChapterThreeCubeScript : MonoBehaviour {

	void Awake(){
		gameObject.tag = "AwesomeCube";
		Debug.Log ("Here: " + gameObject.tag);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
