using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {

	private int id;
	private string name;
	private string type;
	private int price;

	public Item (int id, string name, string type, int price)
	{
		this.id = id;
		this.name = name;
		this.type = type;
		this.price = price;
	}

	public int Id {
		get {
			return this.id;
		}
		set {
			id = value;
		}
	}

	public string Name {
		get {
			return this.name;
		}
		set {
			name = value;
		}
	}

	public string Type {
		get {
			return this.type;
		}
		set {
			type = value;
		}
	}

	public int Price {
		get {
			return this.price;
		}
		set {
			price = value;
		}
	}
}
