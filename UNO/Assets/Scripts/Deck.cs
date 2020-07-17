using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{/*

		List<Card> deck = new List<Card>();

		public Deck()
		{
			makeDeck();
			shuffle();
		}

		public List<Card> getDeck()
		{
			return deck;
		}

		public int getDeckSize()
		{
			return deck.Count;
		}

		public void makeDeck()
		{
			string[] colors = { "Yellow", "Blue", "Green", "Red" };
			for (int j = 0; j < 4; j++)
			{
				for (int i = 0; i < 13; i++)
				{
					for (int k = 0; k < 2; k++)
					{
						if (i == 10)
							deck.Add(new Card("Skip", colors[j]));
						else if (i == 11)
							deck.Add(new Card("Reverse", colors[j]));
						else if (i == 12)
							deck.Add(new Card("Draw Two", colors[j]));
						else
							deck.Add(new Card("" + i, colors[j]));
					}
				}
			}
			for (int i = 0; i < 4; i++)
			{
				deck.Add(new Card("Wild", ""));
				deck.Add(new Card("Wild: Draw Four", ""));
			}
		}

		public void shuffle()
		{
			List<Card> temp = new List<Card>();
			for (int i = 0; i < deck.Count; i++)
			{
			int rand = Random.Range(0, deck.Count);

				while (deck[rand] == null)
				{
					rand = Random.Range(0, deck.Count);
				}

				temp.Add(deck[rand]);
				deck[rand] =  null;
			}

			deck = temp;
		}

		public void removeTopCard()
		{
			deck.RemoveAt(deck.Count - 1);
		}

		public Card getTopCard()
		{
			return deck[deck.Count - 1];
		}
	*/
	}
