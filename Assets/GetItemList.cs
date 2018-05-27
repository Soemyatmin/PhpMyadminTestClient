using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItemList : MonoBehaviour {

	public List<Item> itemList;
	public string[] items;
	// Use this for initialization
	IEnumerator Start () {
		WWW itemData = new WWW ("http://saveinyourbrain.000webhostapp.com/ItemController.php");
		yield return itemData;
		string itemsDataString = itemData.text;
		print (itemsDataString);
		items = itemsDataString.Split (';');

		itemList = new List<Item>();

		for (int i = 0; i < items.Length - 1 ; i++) {
			itemList.Add ( new Item (
				int.Parse((GetDataValue (items [i], "ID:"))),
				(GetDataValue (items [i], "Name:")),
				(GetDataValue (items [i], "Type:")),
				int.Parse((GetDataValue (items [i], "Price:")))
			));
		}

		for (int i = 0; i < itemList.Count ; i++) {
			Item item = itemList[i];
			print ("ID " + item.Id);
			print ("ItemName" + item.Name);
			print ("Type " + item.Type);
			print ("Price" + item.Price);
		}
	}

	string GetDataValue(string data, string index){
		string value = data.Substring (data.IndexOf (index) + index.Length);
		value = value.Remove (value.IndexOf ("|"));
		return value;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
