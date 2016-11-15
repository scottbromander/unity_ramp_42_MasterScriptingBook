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

	/// <summary>
	/// Function to add listener to array of listeners
	/// </summary>
	/// <param name="Event_Type">Event to Listen for</param>
	/// <param name="Listener">Object to listen for event</param>
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

	/// <summary>
	/// Function to post event to listeners
	/// </summary>
	/// <param name="Event_Type">Event to invoke</param>
	/// <param name="Sender">Object invoking event</param>
	/// <param name="Param">Optional argument</param>
	public void PostNotification(EVENT_TYPE Event_Type, Component Sender, Object Param = null){
		List<IListener> ListenList = null;

		if(!Listeners.TryGetValue(Event_Type, out ListenList)){
			return;
		}

		for (int i = 0; i < ListenList.Count; i++) {
			if (!ListenList [i].Equals (null)) {
				ListenList [i].OnEvent (Event_Type, Sender, Param);
			}
				
		}
	}

	public void RemoveEvent(EVENT_TYPE Event_Type){
		Listeners.Remove (Event_Type);
	}


	#endregion
}
