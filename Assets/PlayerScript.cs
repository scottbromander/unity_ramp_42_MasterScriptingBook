using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public GameObject Enemy = null;
	public LayerMask lm;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!Physics.Linecast (transform.position, Enemy.transform.position, lm)) {
			//Debug.Log ("PathClear");
		}
	}

	void OnDrawGizmos(){
		Gizmos.DrawLine(transform.position, Enemy.transform.position);
	}
}
