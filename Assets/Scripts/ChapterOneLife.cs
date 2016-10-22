using UnityEngine;
using System.Collections;

public class ChapterOneLife : MonoBehaviour {

	public string Player = "";
	public int PlayerHealth = 100;
	public Vector3 Position = Vector3.zero;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerHealth == 100) {
			Debug.Log ("Player is at Full Health");
		}
	}
}
