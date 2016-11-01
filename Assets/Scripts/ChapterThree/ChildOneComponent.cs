using UnityEngine;
using System.Collections;

public class ChildOneComponent : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Child one online");
	}

	public void Ping(){
		Debug.Log ("Child one pinged!");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
