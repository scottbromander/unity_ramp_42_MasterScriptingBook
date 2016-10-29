using UnityEngine;
using System.Collections;

public class EnemyOgre : MonoBehaviour {

	public enum AttackType {PUNCH, MAGIC, SWORD, SPEAR};
	public AttackType CurrentAttack = AttackType.PUNCH;

	public int Health = 100;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
