using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatAllocationModule {

	private string[] statNames = new string[5] {"Stamina", "Endurance", "Strength", "Intellect", "Resistance"};
	private string[] statDescriptions = new string[5] {"Energy", "Health", "Physical Damage", "Magical Damage", "Damage Resistance"};
	private bool[] statSelections = new bool[5];

	public int[] pointsToAllocate = new int[5];
	public int[] baseStatPoints = new int[5];

	public int AvailPoints = 5;
	public bool didRunOnce = false;

	public void DisplayStatAllocationModule() {
		if (!didRunOnce) {
			RetrieveStatBaseStatPoints ();
			didRunOnce = true;
		}
		DisplayStatToggleSwitches ();
		DisplayStatIncreaseDecreaseButtons ();
	}

	public void DisplayStatToggleSwitches() {
		for (int i = 0; i < statNames.Length; i++) {
			statSelections [i] = GUI.Toggle (new Rect(10, 60*i + 10, 100, 50), statSelections [i], statNames [i]);
			if (statSelections [0]) {
				GUI.Label (new Rect (20, 60*i + 30, 150, 100), statDescriptions [i]);
			}
		}
	}

	public void DisplayStatIncreaseDecreaseButtons() {
		for (int i = 0; i < pointsToAllocate.Length; i++) {
			if (pointsToAllocate [i] >= baseStatPoints [i] && AvailPoints > 0) {
				if (GUI.Button (new Rect (200, 60 * i + 10, 50, 50), "+")) {
				
				}
				
			}
			if (GUI.Button (new Rect (260, 60*i + 10, 50, 50), "-")) {
				
			}
		}
	}

	public void RetrieveStatBaseStatPoints() {
		BaseCharacterClass cClass = GameInformation.PlayerClass;
		pointsToAllocate[0] = cClass.Stamina;
		baseStatPoints [0] = cClass.Stamina;
		pointsToAllocate[1] = cClass.Endurance;
		baseStatPoints [1] = cClass.Endurance;
		pointsToAllocate[2] = cClass.Strength;
		baseStatPoints [2] = cClass.Strength;
		pointsToAllocate[3] = cClass.Intellect;
		baseStatPoints [3] = cClass.Intellect;
		pointsToAllocate[4] = cClass.Resistance;
		baseStatPoints [4] = cClass.Resistance;
	}

}