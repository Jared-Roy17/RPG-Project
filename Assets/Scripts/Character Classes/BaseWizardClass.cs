using UnityEngine;
using System.Collections;

public class BaseWizardClass : BaseCharacterClass {

	public BaseWizardClass() {
		characterClassName = "Wizard";
		characterClassDescription = "A Powerful Mage";
		Stamina = 12;
		Endurance = 13;
		Strength = 10;
		Intellect = 15;
		Resistance = 11;
	}

}
