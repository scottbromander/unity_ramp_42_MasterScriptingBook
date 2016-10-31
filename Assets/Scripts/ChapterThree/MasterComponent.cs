using UnityEngine;
using System.Collections;

public class MasterComponent : MonoBehaviour {

	private Component[] AllComponents = null;

	// Use this for initialization
	void Start () {
		AllComponents = GetComponents<Component> ();

		foreach (Component C in AllComponents) {
			Debug.Log (C.ToString ());
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
