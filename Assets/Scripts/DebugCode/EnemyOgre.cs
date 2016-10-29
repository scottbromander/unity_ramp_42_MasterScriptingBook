using UnityEngine;
using System.Collections;

public class EnemyOgre : MonoBehaviour {

	public enum AttackType {PUNCH, MAGIC, SWORD, SPEAR};
	public AttackType CurrentAttack = AttackType.PUNCH;

	public int Health = 100;
	public float RecoveryTime = 1.0f;
	public float Speed = 1.0f;
	public string OgreName = "Harry";

	public override string ToString ()
	{
		return string.Format ("***Class EnemyOgre*** OgreName: {0} | Health: {1} | Speed: {2} | CurrentAttack: {3} | RecoveryTime: {4}", 
			OgreName, Health, Speed, CurrentAttack, RecoveryTime);
	}

	// Use this for initialization
	void Start () {
		Debug.Log (ToString ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
