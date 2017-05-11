using UnityEngine;
using System.Collections;

public class BaseWarriorClass : BaseCharacterClass {

	public BaseWarriorClass() {
		characterClassName = "Warrior";
		characterClassDescription = "Strong And Powerful, Heavily Armored.";
		Stamina = 13;
		Endurance = 15;
		Strength = 15;
		Intellect = 10;
		Resistance = 15;
	}

}
