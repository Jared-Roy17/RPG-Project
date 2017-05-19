using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCreatePlayerFunctions {

	public StatAllocationModule statAllocationModule = new StatAllocationModule();

	private int classSelection;
	private string[] classSelectionNames = new string[] {"Wizard", "Warrior", "Archer"};
	private string playerName = "Enter Name";
	private string playerBio = "Enter Player Bio";
	private bool isMale = true;
	private int genderSelection;
	private string[] genderTypes = new string[2] {"Male", "Female"};

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
		playerName = GUI.TextArea (new Rect(20,10,150,25), playerName, 20);
		playerBio = GUI.TextArea (new Rect(20,90,250,200),playerBio, 250);
		genderSelection = GUI.SelectionGrid (new Rect (300, 10, 100, 100), genderSelection, genderTypes, 1);

	}

	private void ChooseClass (int classSelection){
		if (classSelection == 0) {
			GameInformation.PlayerClass = new BaseWizardClass ();
		} else if (classSelection == 1) {
			GameInformation.PlayerClass = new BaseWarriorClass ();
		}
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
		if (CreateAPlayerGUI.currentState != CreateAPlayerGUI.CreateAPlayerStates.FINALSETUP) {
			if (GUI.Button (new Rect (525, 370, 50, 50), "Next")) {
				if (CreateAPlayerGUI.currentState == CreateAPlayerGUI.CreateAPlayerStates.CLASSSELECTION) {
					ChooseClass (classSelection);
					CreateAPlayerGUI.currentState = CreateAPlayerGUI.CreateAPlayerStates.STATALLOCATION;
				} else if (CreateAPlayerGUI.currentState == CreateAPlayerGUI.CreateAPlayerStates.STATALLOCATION) {
					statAllocationModule.pointsToAllocate [0] = GameInformation.Stamina;
					statAllocationModule.pointsToAllocate [1] = GameInformation.Endurance;
					statAllocationModule.pointsToAllocate [2] = GameInformation.Intellect;
					statAllocationModule.pointsToAllocate [3] = GameInformation.Strength;
					statAllocationModule.pointsToAllocate [4] = GameInformation.Resistance;
					CreateAPlayerGUI.currentState = CreateAPlayerGUI.CreateAPlayerStates.FINALSETUP;
				}
			}
		} else if (CreateAPlayerGUI.currentState == CreateAPlayerGUI.CreateAPlayerStates.FINALSETUP) {
			if (GUI.Button (new Rect (525, 370, 50, 50), "Finish")) {
				Debug.Log ("MAKE FINAL SAVE");
			}
		}
		if (CreateAPlayerGUI.currentState != CreateAPlayerGUI.CreateAPlayerStates.CLASSSELECTION) {
			if (GUI.Button (new Rect (290, 370, 50, 50), "Back")) {
				if (CreateAPlayerGUI.currentState == CreateAPlayerGUI.CreateAPlayerStates.STATALLOCATION) {
					statAllocationModule.didRunOnce = false;
					GameInformation.PlayerClass = null;
					CreateAPlayerGUI.currentState = CreateAPlayerGUI.CreateAPlayerStates.CLASSSELECTION;
				} else if (CreateAPlayerGUI.currentState == CreateAPlayerGUI.CreateAPlayerStates.FINALSETUP) {
					CreateAPlayerGUI.currentState = CreateAPlayerGUI.CreateAPlayerStates.STATALLOCATION;
				}
			}
		}
	}

}
