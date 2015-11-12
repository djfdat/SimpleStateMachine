using UnityEngine;
using System.Collections;

[System.Serializable]
public class State : MonoBehaviour
{
	#region Delegates
	public delegate void d_OnStateEnter();
	public delegate void d_OnStateTick();
	public delegate void d_OnStateExit();
	#endregion Delegates

	#region Events
	public event d_OnStateEnter OnStateEnter;
	public event d_OnStateTick  OnStateTick;
	public event d_OnStateExit  OnStateExit;
	#endregion Events

	#region Triggers
	public void Trigger_OnStateEnter()
	{
		if (OnStateEnter != null) OnStateEnter();
	}

	public void Trigger_OnStateTick()
	{
		if (OnStateTick != null) OnStateTick();
	}

	public void Trigger_OnStateExit()
	{
		if (OnStateExit != null) OnStateExit();
	}
	#endregion Triggers

	#region Add Events
	public void Add_OnStateEnter(d_OnStateEnter StateEnter)
	{
		if (StateEnter != null) OnStateEnter += StateEnter;
	}

	public void Add_OnStateTick(d_OnStateTick StateTick)
	{
		if (StateTick != null) OnStateTick += StateTick;
	}

	public void Add_OnStateExit(d_OnStateExit StateExit)
	{
		if (StateExit != null) OnStateExit += StateExit;
	}
	#endregion Add Events

	#region Remove Events
	public void Remove_OnStateEnter(d_OnStateEnter StateEnter)
	{
		if (OnStateEnter != null) OnStateEnter -= StateEnter;
	}

	public void Remove_OnStateTick(d_OnStateTick StateTick)
	{
		if (OnStateTick != null) OnStateTick -= StateTick;
	}

	public void Remove_OnStateExit(d_OnStateExit StateExit)
	{
		if (OnStateExit != null) OnStateExit -= StateExit;
	}
	#endregion Remove Events

}
