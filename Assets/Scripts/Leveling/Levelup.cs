using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelup {

	public int MaxPlayerLevel = 50;

	public void LevelUpCharacter(){
		if (GameInformation.CurrentXP > GameInformation.RequiredXP) {
			GameInformation.CurrentXP -= GameInformation.RequiredXP;
		} else {
			GameInformation.CurrentXP = 0;
		}
		if (GameInformation.PlayerLevel < MaxPlayerLevel) {
			GameInformation.PlayerLevel += 1;
		} else {
			GameInformation.PlayerLevel = MaxPlayerLevel;
		}
		DetermineRequiredXP ();
	}

	private void DetermineRequiredXP(){
		float temp = (GameInformation.PlayerLevel * 1000) + 250;
		//GameInformation.RequiredXP = temp; 
	}



}
