﻿using UnityEngine;
using System.Collections;

public class BaseCharacterClass {

	protected string characterClassName;
	protected string characterClassDescription;

	public int stamina;
	public int endurance;
	public int strength;
	public int intellect;
	public int resistance;

	public string CharacterClassName {
		get{ return characterClassName; }
		set{ characterClassName = value; }
	}
	public string CharacterClassDescription {
		get{ return characterClassDescription; }
		set{ characterClassDescription = value; }
	}
	public int Stamina {
		get{ return stamina; }
		set{ stamina = value; }
	}
	public int Endurance {
		get{ return endurance; }
		set{ endurance = value; }
	}
	public int Strength {
		get{ return strength; }
		set{ strength = value; }
	}
	public int Intellect {
		get{ return intellect; }
		set{ intellect = value; }
	}
	public int Resistance {
		get{ return resistance; }
		set{ resistance = value; }
	}
}
