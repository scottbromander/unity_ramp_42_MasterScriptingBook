using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EventManager : MonoBehaviour {

	#region C# properties

	public static EventManager Instance {
		get {return instance;}
		set { }
	}
	#endregion

	#region variables
	private static EventManager instance = null;

	private Dictionary<EVENT_TYPE, List<IListener>> Listeners = new Dictionary<EVENT_TYPE, List<IListener>>();
	#endregion

	#region methods

	void Awake () {
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (gameObject);
		} else {
			DestroyImmediate (this);
		}
	}

	public void AddListener(EVENT_TYPE Event_Type, IListener Listener){
		List<IListener> ListenList = null;

		if(Listeners.TryGetValue(Event_Type, out ListenList)){
			ListenList.Add(Listener);
			return;
		}

		ListenList = new List<IListener>();
		ListenList.Add(Listener);
		ListenList.Add(Event_Type, ListenList);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
