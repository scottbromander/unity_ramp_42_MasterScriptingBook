using UnityEngine;
using System.Collections;

public class Village : MonoBehaviour {

	public Characters[] characters = null;

	// Use this for initialization
	void Start () {
		characters = new Characters[5];

		characters [0] = new ManCharacter ();
		characters [1] = new WomanCharacter ();
		characters [2] = new OrcCharacter ();
		characters [3] = new ManCharacter ();
		characters [4] = new WomanCharacter ();

		EnterTavern ();
	}

	public void EnterTavern(){
		foreach (Characters Char in characters) {
			Char.SayGreeting ();
		}
	}
}
