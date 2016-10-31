using UnityEngine;
using System.Collections;

public class ChildTwoComponent : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Child two online");
	}

	public void Ping(){
		Debug.Log ("Child two pinged!");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
