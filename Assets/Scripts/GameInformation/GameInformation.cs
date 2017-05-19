using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation : MonoBehaviour {
	
	void Awake() {
		DontDestroyOnLoad (gameObject);
	}
		
	public static bool isMale { get; set; }
	public static BaseCharacterClass PlayerClass { get; set;}
	public static BaseEquipment EquipmentOne{ get; set;}
	public static string PlayerName { get; set;}
	public static int PlayerLevel { get; set;}
	public static int Stamina { get; set;}
	public static int Endurance { get; set;}
	public static int Intellect { get; set;}
	public static int Strength { get; set;}
	public static int Resistance{ get; set;}
	public static int CurrentXP{ get; set;}
	public static int RequiredXP{ get; set;}
	public static int Gold { get; set;}
}
