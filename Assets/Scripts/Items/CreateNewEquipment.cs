using UnityEngine;
using System.Collections;

public class CreateNewEquipment : MonoBehaviour {

	private BaseEquipment newEquipment;
	private string[] itemNames = new string[4]{ "Lesser", "Common", "Greater", "Legendary" };
	private string[] itemDes = new string[2]{"A New Item", "A Used Item"};

	// Use this for initialization
	void Start () {
		CreateEquipment ();
		Debug.Log (newEquipment.ItemName);
		Debug.Log (newEquipment.ItemDescription);
		Debug.Log (newEquipment.ItemID.ToString());
		Debug.Log (newEquipment.EquipmentType.ToString());
		Debug.Log (newEquipment.Stamina.ToString());
		Debug.Log (newEquipment.Endurance.ToString());
	}
	
	private void CreateEquipment() {
		newEquipment = new BaseEquipment ();
		newEquipment.ItemName = itemNames [Random.Range (0, 3)] + " Item";
		newEquipment.ItemID = Random.Range (1, 101);
		ChooseItemType ();
		newEquipment.ItemDescription = itemDes [Random.Range (0, itemDes.Length)];
		newEquipment.Stamina = Random.Range (1, 11);
		newEquipment.Endurance = Random.Range (1, 11);
		newEquipment.Intellect = Random.Range (1, 11);
		newEquipment.Strength = Random.Range (1, 11);
	}

	private void ChooseItemType() {
		int randomTemp = Random.Range (1,7);
		if (randomTemp == 1) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HELMET;
		}else if (randomTemp == 2) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CHESTPLATE;
		}else if (randomTemp == 3) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.SHOULDERPADS;
		}else if (randomTemp == 4) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.LEGS;
		}else if (randomTemp == 5) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.BOOTS;
		}else if (randomTemp == 6) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.NECKLACE;
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
