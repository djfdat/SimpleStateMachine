using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum EDemoStates
{
	State1,
	State2,
	State3
}

public class SingleStateMachineLiteDemo : MonoBehaviour
{
	[SerializeField]
	private SingleStateMachineLite<EDemoStates> Demo_SSML;

	void Start()
	{
		Debug.Log("Starting Demo"); 

		Demo_SSML = new SingleStateMachineLite<EDemoStates>();

		Debug.Log("Subscribing to Events");

		Demo_SSML.OnStateEnter += Demo_SSML_OnStateEnter;
		Demo_SSML.OnStateExit += Demo_SSML_OnStateExit;

		// Uncomment the line below to allow events to refire when setting activeState to the same value
		//Demo_SSML.bAllowStateReenter = true;
	}

	#region Event Handlers
	private void Demo_SSML_OnStateEnter(EDemoStates state)
	{
		Debug.Log("Entering state " + state.ToString());

		switch (state)
		{
			case EDemoStates.State1:
				break;
			case EDemoStates.State2:
				break;
			case EDemoStates.State3:
				break;
			default:
				break;
		}
	}

	private void Demo_SSML_OnStateExit(EDemoStates state)
	{
		Debug.Log("Exiting state " + state.ToString());

		switch (state)
		{
			case EDemoStates.State1:
				break;
			case EDemoStates.State2:
				break;
			case EDemoStates.State3:
				break;
			default:
				break;
		}
	}
	#endregion Event Handlers

	#region Button Events
	public void OnClient_SetState1()
	{
		Debug.Log("Setting active state to State1");
		Demo_SSML.ActiveState = EDemoStates.State1;
	}

	public void OnClient_SetState2()
	{
		Debug.Log("Setting active state to State2");
		Demo_SSML.ActiveState = EDemoStates.State2;
	}

	public void OnClient_SetState3()
	{
		Debug.Log("Setting active state to State3");
		Demo_SSML.ActiveState = EDemoStates.State3;
	}
	#endregion Button Events
}
