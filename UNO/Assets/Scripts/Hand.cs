using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{

		List<Card> hand = new List<Card>();
		Deck deck = new Deck();
		int playerNum;

		public Hand(Deck deck, int playerNum)
		{
			this.deck = deck;
			this.playerNum = playerNum + 1;
			fillHand();
		}

		public int getPlayerNum()
		{
			return playerNum;
		}

		public List<Card> getHand()
		{
			return hand;
		}


		public void DisplayHand()
		{
			int i = 1;
			Debug.Log("*** Player " + playerNum + " ***");
			foreach (Card c in hand)
			{
				Debug.Log(i + ": " + c);
				i++;
			}
		}

		public void fillHand()
		{
			int deckSize = deck.getDeckSize();

			for (int i = deckSize - 1; i >= deckSize - 7; i--)
			{
				hand.Add(deck.getDeck()[i]);
				deck.removeTopCard();
			}
		}

		public void remove(int index)
		{
			hand.RemoveAt(index);
		}

		public void drawCard()
		{
			hand.Add(deck.getTopCard());
			deck.removeTopCard();
		}
	}
