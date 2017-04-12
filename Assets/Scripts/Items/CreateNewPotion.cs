using UnityEngine;
using System.Collections;

public class CreateNewPotion : MonoBehaviour {

	private BasePotion newPotion;

	void Start () {
		CreatePotion ();
		Debug.Log (newPotion.ItemName);
		Debug.Log (newPotion.ItemDescription);
		Debug.Log (newPotion.ItemID.ToString());
		Debug.Log (newPotion.PotionType.ToString());

	}

	private void CreatePotion() {
		newPotion = new BasePotion ();
		newPotion.ItemName = "Potion";
		newPotion.ItemDescription = "This is a potion";
		newPotion.ItemID = Random.Range (1, 101);
		ChoosePotionType ();
		}

	private void ChoosePotionType() {
		int randomTemp = Random.Range (0, 5);
		if (randomTemp == 0) {
			newPotion.PotionType = BasePotion.PotionTypes.HEALTH;
		}else if (randomTemp == 1) {
			newPotion.PotionType = BasePotion.PotionTypes.STAMINA;
		}else if (randomTemp == 2) {
			newPotion.PotionType = BasePotion.PotionTypes.STRENGHTH;
		}else if (randomTemp == 3) {
			newPotion.PotionType = BasePotion.PotionTypes.INTELLECT;
		}else if (randomTemp == 4) {
			newPotion.PotionType = BasePotion.PotionTypes.SPEED;
		}
	}

}
