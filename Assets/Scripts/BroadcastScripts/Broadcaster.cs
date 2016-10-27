using UnityEngine;
using System.Collections;

public class Broadcaster : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SendMessage ("MyFunction", SendMessageOptions.DontRequireReceiver);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
