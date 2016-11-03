using UnityEngine;
using System.Collections;

public class ChildEnemy : MonoBehaviour {

	private GameObject parent;

	// Use this for initialization
	void Start () {
		parent = GameObject.Find ("Player");
		transform.parent = parent.transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
