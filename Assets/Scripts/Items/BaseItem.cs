using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseItem {

	protected string itemName;
	protected string itemDescription;
	public int itemID;
	public enum ItemTypes {
		EQUIPMENT,
		WEAPON,
		POTION,
	}
	protected ItemTypes itemTypes;

	public string ItemName {
		get{ return itemName; }
		set{ itemName = value; }
	}
	public string ItemDescription {
		get{ return itemDescription; }
		set{ itemDescription = value; }
	}
	public int ItemID {
		get{ return itemID; }
		set{ itemID = value; }
	}
	public ItemTypes itemType {
		get{ return itemType; }
		set{ itemType = value; }
	}
}
