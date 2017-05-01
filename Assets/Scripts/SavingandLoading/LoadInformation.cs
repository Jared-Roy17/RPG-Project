using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInformation : MonoBehaviour {

	public static void LoadAllInformation() {
		GameInformation.PlayerName = PlayerPrefs.GetString ("PLAYERNAME");
		GameInformation.PlayerLevel = PlayerPrefs.GetInt ("PLAYERLEVEL");
		GameInformation.Stamina = PlayerPrefs.GetInt ("STAMINA");
		GameInformation.Endurance = PlayerPrefs.GetInt ("ENDURANCE");
		GameInformation.Intellect = PlayerPrefs.GetInt ("INTELLECT");
		GameInformation.Strength = PlayerPrefs.GetInt ("STRENGTH");
		GameInformation.Resistance = PlayerPrefs.GetInt ("RESISTANCE");
		GameInformation.Gold = PlayerPrefs.GetInt ("GOLD");

		if (PlayerPrefs.GetString ("EQUIPMENTITEM1") != null) {
			GameInformation.EquipmentOne = (BaseEquipment)PPSerialization.Load ("EQUIPMENTITEM1");
		}
	}

}
//https://gamedevelopment.tutsplus.com/tutorials/how-to-save-and-load-your-players-progress-in-unity--cms-20934