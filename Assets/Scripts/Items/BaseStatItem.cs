using UnityEngine;
using System.Collections;

public class BaseStatItem : BaseItem {

	protected int stamina;
	protected int endurance;
	protected int strength;
	protected int intellect;

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
		set{ strength = value;	}
	}
	public int Intellect {
		get{ return intellect; }
		set{ intellect = value; }
	}
}
