using UnityEngine;
using System.Collections;

public class ChapterThreeGameManager : MonoBehaviour {

	public static ChapterThreeGameManager Instance {
		get {
			return Instance;
		}
	}

	private static ChapterThreeGameManager instance = null;

	public int HighScore = 0;
	public bool IsPaused = false;
	public bool InputAllowed = true;

	void Awake (){   
		 if(instance){
		   DestroyImmediate(gameObject);
		   return;
		 }

		 //Make this active and only instance
		 instance = this;

		 //Make game manager persistent
		 DontDestroyOnLoad(gameObject);
	}
}
