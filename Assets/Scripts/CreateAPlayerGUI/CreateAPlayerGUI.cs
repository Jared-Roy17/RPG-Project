using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAPlayerGUI : MonoBehaviour {

	public enum CreateAPlayerStates {
		CLASSSELECTION,
		STATALLOCATION,
		FINALSETUP,

	}

	public DisplayCreatePlayerFunctions displayFunctions = new DisplayCreatePlayerFunctions();
	public static CreateAPlayerStates currentState;

	void Start () {
		currentState = CreateAPlayerStates.CLASSSELECTION;
	}

	void Update ()
	{
		switch (currentState) {
		case(CreateAPlayerStates.CLASSSELECTION):
			break;
		case(CreateAPlayerStates.STATALLOCATION):
			break;
		case(CreateAPlayerStates.FINALSETUP):
			break;
		}
	}

	void OnGUI(){
		displayFunctions.DisplayMainItems ();
		if (currentState == CreateAPlayerStates.CLASSSELECTION) {
			displayFunctions.DisplayClassSelections ();
		}
		if (currentState == CreateAPlayerStates.STATALLOCATION) {
			displayFunctions.DisplayStatAllocation ();
		}
		if (currentState == CreateAPlayerStates.FINALSETUP) {
			displayFunctions.DisplayFinalSetup ();
		}
	}

}
