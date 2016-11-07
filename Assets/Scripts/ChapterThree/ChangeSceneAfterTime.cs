using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;

public class ChangeSceneAfterTime : MonoBehaviour {

	public float timeUntilChange = 10.0f;
	private float currentTime = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		if (currentTime > timeUntilChange) {
			Application.LoadLevel ("Chapter3_2");
		}
	}
}
