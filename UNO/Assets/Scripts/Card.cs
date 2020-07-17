using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

	

	private string type;
	private Color color;

	public Card()
	{
		type = null;
		color = Color.black;
	}

	public void CreateCard(string type, Color color)
	{
		this.type = type;
		this.color = color;
		//research more
		gameObject.GetComponent<Renderer>().material.SetColor("Standard", color);
	}

		public string getType()
		{
			return type;
		}

		public Color getColor()
		{
			return color;
		}

		public void setType(string type)
		{
			this.type = type;
		}

		public void setColor(Color color)
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
