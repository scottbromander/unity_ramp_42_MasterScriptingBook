using UnityEngine;
using System.Collections;

public class BasicEnemyMovement : MonoBehaviour {

	public float AmountToMove = 1.0f;
	private float _amountMoved = 0.0f;
	private bool _moveBack = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var movement = AmountToMove;

		if (_amountMoved > 50.0f) {
			_moveBack = !_moveBack;
			_amountMoved = 0;
		}

		if (_moveBack) {
			movement *= 1;
		} else {
			movement *= -1;
		}

		transform.localPosition += new Vector3 (0, 0, movement);

		_amountMoved += Mathf.Abs(movement);
	}
}
