using UnityEngine;
using System.Collections;

public class BasePlayer {

    private string playerName;
    private int playerLevel;
    private BaseCharacterClass playerClass;

    private int stamina;//Energy
    private int endurance;//Health
    private int intellect;//Magical damege
    private int strength;//Physical Damege
	private int resistance;//All Damage Reduction

	private int gold; //In game Currency

	private int currentXP;
	private int requiredXP;

   // public string PlayerName {
		//get{ return playerName;} 
		//set{ playerName = value;} 
	//}
  	
	public string PlayerName{ get; set;}
	public int CurrentXP{ get; set;}
	public int RequiredXP{ get; set;}

    public int PlayerLevel {
        get { return playerLevel; }
        set { playerLevel = value; }
    }
    public BaseCharacterClass PlayerClass {
        get { return playerClass; }
        set { playerClass = value; }
    }
    public int Stamina {
        get { return stamina; }
        set { stamina = value; }
    }
    public int Endurance {
        get { return endurance; }
        set { endurance = value; }
    }
    public int Intellect {
        get { return intellect; }
        set { intellect = value; }
    }
    public int Strength {
        get { return strength; }
        set { strength = value; }
    }
	public int Resistance {
		get{ return resistance; }
		set{ resistance = value; }
	}
	public int Gold {
		get{return gold;}
		set{gold = value;}
	}
}