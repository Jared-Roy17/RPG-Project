using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatAllocationModule {

	private string[] statNames = new string[0] ("Stamina", "Endurance", "Strength", "Intellect", "Resistance");
	private string[] statDescription = new string[6] ("Energy","Health","Physical Damage","Magical Damage","Damage Resistance");
	private bool[] statSelection = new bool[6];

	public void DisplayStatAllocationModule() {
	
		DisplayStatToggleSwitches ();

	}

	private void DisplayStatToggleSwitches() {
		for (int i = 0; i < statNames.Length; i++) {
			statSelection [i] = GUI.Toggle (new Rect (10,60*i + 10,50,50), statSelections [i], statNames [i]);
		}
	}

}