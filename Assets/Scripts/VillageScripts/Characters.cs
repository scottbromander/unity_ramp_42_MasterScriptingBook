using UnityEngine;
using System.Collections;

public class Characters {

	public string CharName = "";
	public int Health = 100;
	public int Strength = 100;
	public float Speed = 10.0f;
	public bool isAwake = true;

	public virtual void SayGreeting(){
		Debug.Log ("Hello, my friend");
	}
}

public class ManCharacter : Characters {
	public override void SayGreeting(){
		Debug.Log ("Hello, I am man!");
	}
}

public class WomanCharacter : Characters {
	public override void SayGreeting(){
		Debug.Log ("Hello, I am woman!");
	}
}

public class OrcCharacter : Characters {
	public override void SayGreeting(){
		Debug.Log ("Hello, I am orc!");
	}
}