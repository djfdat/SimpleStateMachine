using UnityEngine;
using System;

[Serializable]
public class SingleStateMachine : StateMachine
{
	[SerializeField]
	protected State activeState;
	public State ActiveState
	{
		get
		{
			return activeState;
		}
		set
		{
			if (activeState != null) activeState.Trigger_OnStateExit();
			activeState = value;
			if (activeState != null) activeState.Trigger_OnStateEnter();
		}
	}
}