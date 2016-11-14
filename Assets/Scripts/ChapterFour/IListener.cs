using UnityEngine;
using System.Collections;

public enum EVENT_TYPE {
	GAME_INIT,
	GAME_END,
	AMMO_EMPTY,
	HEALTH_CHANGE,
	DEAD
};

public interface IListener {
	void OnEvent(EVENT_TYPE Event_Type, Component Sender, Object Param = null);
}