﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInformation : MonoBehaviour {

	public static void SaveAllInformation (){
		PlayerPrefs.SetInt ("PLAYERLEVEL", GameInformation.PlayerLevel);
		PlayerPrefs.SetString ("PLAYERNAME", GameInformation.PlayerName);
		PlayerPrefs.SetInt ("STAMINA", GameInformation.Stamina);
		PlayerPrefs.SetInt ("ENDURANCE", GameInformation.Endurance);
		PlayerPrefs.SetInt ("INTELLECT", GameInformation.Intellect);
		PlayerPrefs.SetInt ("STRENGTH", GameInformation.Strength);
		PlayerPrefs.SetInt ("RESISTANCE", GameInformation.Resistance);
		PlayerPrefs.SetInt ("GOLD", GameInformation.Gold);
		if (GameInformation.EquipmentOne != null){
			PPSerialization.Save ("EQUIPMENTITEM1", GameInformation.EquipmentOne);
	}
		Debug.Log ("SAVED ALL INFORMATION");
	}

}
