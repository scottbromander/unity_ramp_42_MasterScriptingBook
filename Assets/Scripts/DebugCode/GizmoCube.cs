using UnityEngine;
using System.Collections;

public class GizmoCube : MonoBehaviour {

	public bool DrawGizmos = true;

	void OnDrawGizmos(){
		if (!DrawGizmos)
			return;

		Gizmos.color = Color.blue;

		Gizmos.DrawRay (transform.position, transform.forward.normalized * 4.0f);

		Gizmos.color = Color.red;

		Gizmos.DrawWireSphere (transform.position, 4.0f);

		Gizmos.color = Color.white;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
