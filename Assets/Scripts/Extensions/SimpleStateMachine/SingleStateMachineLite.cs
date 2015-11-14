using UnityEngine;
using System;

[Serializable]
public class SingleStateMachineLite<TEnum>
{
	public bool bAllowStateReenter = false;

	[SerializeField]
	private TEnum activeState;
	public TEnum ActiveState
	{
		get
		{
			return activeState;
		}
		set
		{
			if (IsStateActive(value) && !bAllowStateReenter)
			{
				Debug.LogWarning("Attempting to set state that is already active.\nIf this is desired, please set bAllowStateReenter to true on this SingleStateMachineLite instance.");
				return;
			}

			if (OnStateExit != null && activeState != null) OnStateExit(activeState);
			activeState = value;
			if (OnStateEnter != null && activeState != null) OnStateEnter(activeState);
		}
	}

	// For consistency with MultiStateMachineLite;
	public bool IsStateActive(TEnum state)
	{
		return activeState.Equals(state);
	}

	#region Delegates
	public delegate void OnStateEnterDelegate(TEnum state);
	public delegate void OnStateExitDelegate(TEnum state);
	#endregion Delegates

	#region Events
	public event OnStateEnterDelegate OnStateEnter;
	public event OnStateExitDelegate OnStateExit;
	#endregion Events
}
