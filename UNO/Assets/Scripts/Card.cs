using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

	

		private string type;
		private string color;

		public Card()
		{
			type = null;
			color = null;
		}

		public Card(string type, string color)
		{
			this.type = type;
			this.color = color;
		}

		public string getType()
		{
			return type;
		}

		public string getColor()
		{
			return color;
		}

		public void setType(string type)
		{
			this.type = type;
		}

		public void setColor(string color)
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
