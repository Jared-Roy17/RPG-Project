using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatAllocationModule {

	private string[] statNames = new string[5] ("Stamina", "Endurance", "Strength", "Intellect", "Resistance");
	private string[] statDescription = new string[5] ("Energy","Health","Physical Damage","Magical Damage","Damage Resistance");
	private bool[] statSelection = new bool[5];

	private int[] pointsToAllocate = new int[5];
	private int[] baseStatPoints = new int[5];

	public void DisplayStatAllocationModule() {
	
		DisplayStatToggleSwitches ();

	}

	private void DisplayStatToggleSwitches() {
		for (int i = 0; i < statNames.Length; i++) {
			statSelection [i] = GUI.Toggle (new Rect(10, 60*i + 10, 100, 50), statSelections [i], statNames [i]);
			if (statSelections [0]) {
				GUI.Label (new Rect (0, 0, 0, 0), statDescriptions [0]);
			}
		}
	}
		
	private void RetrieveStatBaseStatPoints(){
		BaseCharacterClass cClass = new BaseWizardClass ();
		pointsToAllocate[0] = cClass.Stamina;
		pointsToAllocate[1] = cClass.Endurance;
		pointsToAllocate[0] = cClass.Stamina;
		pointsToAllocate[0] = cClass.Stamina;
		pointsToAllocate[0] = cClass.Stamina;
	}

}