using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

	[SerializeField] private Material[] colors;

	private string type;
	private Material color;

	public Card()
	{
		type = null;
		color = null;
	}

	public void CreateCard(string type, int color)
	{
		this.type = type;
		this.color = colors[color];
		//research more
		gameObject.GetComponent<MeshRenderer>().material = this.color;

	}

		public string getType()
		{
			return type;
		}

		public Material getColor()
		{
			return color;
		}

		public void setType(string type)
		{
			this.type = type;
		}

		public void setColor(Material color)
		{
			this.color = color;
		}

		public string toString()
		{
			if (color.Equals(""))
				return type;
			else
				return color + " " + type;
		}
	
}
