using UnityEngine;
using System;
using System.Linq;
using System.Collections.Generic;

[Serializable]
public class MultiStateMachine : StateMachine
{
	protected bool allowRepeatedStates = false;
	public bool AllowRepeatedStates
	{
		get
		{
			return allowRepeatedStates;
		}
		set
		{
			allowRepeatedStates = value;

			if (!allowRepeatedStates)
			{
				activeStates = activeStates.Distinct().ToList();
			}
		}
	}

	[SerializeField]
	protected List<State> activeStates;
	public List<State> ActiveStates
	{
		get
		{
			return activeStates;
		}
	}

	public bool AddState(State state)
	{
		// check for repeated states
		if (!IsStateActive(state) || allowRepeatedStates)
		{
			ActiveStates.Add(state);
			state.Trigger_OnStateEnter();
			return true;
		}
		return false;
	}

	public bool RemoveState(State state, bool removeAll = false)
	{
		if (IsStateActive(state))
		{
			if (removeAll)
			{
				while (IsStateActive(state))
				{
					state.Trigger_OnStateExit();
					ActiveStates.Remove(state);
				}
			}
			else
			{
				state.Trigger_OnStateExit();
				ActiveStates.Remove(state);
			}
			return true;
		}
		return false;
	}

	public bool IsStateActive(State state)
	{
		return ActiveStates.Contains(state);
	}

}