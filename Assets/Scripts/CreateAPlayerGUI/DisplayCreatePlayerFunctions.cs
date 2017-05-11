using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCreatePlayerFunctions {

	private StatAllocationModule statAllocationModule = new StatAllocationModule();

	private int classSelection;
	private string[] classSelectionNames = new string[] {"Wizard", "Warrior", "Archer"};

	public void DisplayClassSelections() {
		classSelection = GUI.SelectionGrid (new Rect (50, 50, 250, 300), classSelection, classSelectionNames, 3);
		GUI.Label (new Rect (450, 50, 300, 300), FindClassDescription (classSelection));
		GUI.Label (new Rect (450, 100, 300, 300), FindClassStatValues (classSelection));
	}

	private string FindClassDescription (int classSelection){
		if (classSelection == 0) {
			BaseCharacterClass tempClass = new BaseWizardClass ();
			return tempClass.CharacterClassDescription;
		}else if(classSelection == 1) {
			BaseCharacterClass tempClass = new BaseWarriorClass ();
			return tempClass.CharacterClassDescription;
		}else if(classSelection == 2) {
			BaseCharacterClass tempClass = new BaseArcherClass ();
			return tempClass.CharacterClassDescription;
		}
		return "NO CLASS FOUND";
	}

	private string FindClassStatValues (int classSelection) {
		if (classSelection == 0) {
			BaseCharacterClass tempClass = new BaseWizardClass ();
			string tempStats = "Stamina " + tempClass.Stamina + "\n" + "Endurance " + tempClass.Endurance + "\n" + "Strength " + tempClass.Strength + "\n" + "Intellect " + tempClass.Intellect + "\n" + "Resistance " + tempClass.Resistance;
			return tempStats;
		} else if (classSelection == 1) {
			BaseCharacterClass tempClass = new BaseWarriorClass ();
			string tempStats = "Stamina " + tempClass.Stamina + "\n" + "Endurance " + tempClass.Endurance + "\n" + "Strength " + tempClass.Strength + "\n" + "Intellect " + tempClass.Intellect + "\n" + "Resistance " + tempClass.Resistance;
			return tempStats;
		}else if (classSelection == 2) {
			BaseCharacterClass tempClass = new BaseArcherClass ();
			string tempStats = "Stamina " + tempClass.Stamina + "\n" + "Endurance " + tempClass.Endurance + "\n" + "Strength " + tempClass.Strength + "\n" + "Intellect " + tempClass.Intellect + "\n" + "Resistance " + tempClass.Resistance;
			return tempStats;
		}
		return "NO STATS FOUND";
	}

	public void DisplayStatAllocation(){
		statAllocationModule.DisplayStatAllocationModule ();
	}

	public void DisplayFinalSetup(){
		
	}

	public void DisplayMainItems() {
		Transform player = GameObject.FindGameObjectWithTag ("Player").transform;
		GUI.Label (new Rect (Screen.width / 2, 20, 250, 100), "CREATE NEW PLAYER");

		if (GUI.Button (new Rect (340, 370, 50, 50), "<<<")) {
			player.Rotate (Vector3.up * 10);
		}
		if (GUI.Button (new Rect (470, 370, 50, 50), ">>>")) {
			player.Rotate (Vector3.down * 10); 
		}
	}

}
