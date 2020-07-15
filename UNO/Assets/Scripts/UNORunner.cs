using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UNORunner : MonoBehaviour
{
		static Deck deck = new Deck();
		static List<Hand> hands = new List<Hand>();
		static Card topCard = new Card();

		static bool isGameActive = true;

    private void Start()
    {
		StartGame();
	}

		//The act of drawing cards
		public static void drawPhase(Hand hand)
		{
			while (!CanPlayACard(hand) && isGameActive)
			{
				hand.drawCard();
			}

			if (isGameActive)
			{
				//System.out.println();
				mainPhase(hand);
			}
		}

		//The act of playing cards
		public static void mainPhase(Hand hand)
		{
			if (hand.getHand().Count == 0)
			{
				isGameActive = false;
				Debug.Log("Player " + hand.getPlayerNum() + " Wins!");
			}

			hand.DisplayHand();

			while (CanPlayACard(hand))
			{
				Debug.Log("\nChoose a card to play. Top card: " + topCard);
				PlaceCard(hand);
				if (hands.IndexOf(hand) == hands.Count - 1)
				{
					mainPhase(hands[0]);
				}
				else
				{
					mainPhase(hands[hands.IndexOf(hand) + 1]);
				}
			}

			if (isGameActive)
				drawPhase(hand);
		}

		//All the preliminary stuff
		public static void StartGame()
		{
			topCard = deck.getDeck()[deck.getDeckSize() - 1];
			deck.removeTopCard();

			Debug.Log("How many players?");
		int numPlayers = Console.ReadLine();
			for (int i = 0; i < numPlayers; i++)
			{
				hands.Add(new Hand(deck, i));
			}

			mainPhase(hands[0]);
		}

		//Places the card if all conditions are met, accounts for wild cards
		public static void PlaceCard(Hand hand)
		{
			int input = scan.nextInt();
			input--;

			//Makes sure it's a valid input
			while (input > hand.getHand().Count)
			{
				Debug.Log("Enter a valid option");
				input = scan.nextInt();
				input--;
			}

			Card choosenCard = hand.getHand()[input];

			//The wild card situation
			if (choosenCard.getColor().Equals(""))
			{
				hand.remove(input);
				Debug.Log("Enter 1 for Yellow, 2 for Blue, 3 for Green, 4 for Red.");
				input = scan.nextInt();

				//Makes sure it's a valid input
				while (input < 1 || input > 4)
				{
					Debug.Log("Enter a vaild number");
					input = scan.nextInt();
				}
				input--;
				string[] colors = { "Yellow", "Blue", "Green", "Red" };
				choosenCard.setColor(colors[input]);
				topCard = choosenCard;

			}
			//Other situations
			else if (CanPlayCard(choosenCard))
			{
				topCard = choosenCard;
				hand.remove(input);
			}
		}

		//Tests is any card in the hand can be played
		public static bool CanPlayACard(Hand hand)
		{
			foreach (Card c in hand.getHand())
			{
				if (CanPlayCard(c))
					return true;
			}
			return false;
		}

		//Tests if that card can be played
		public static bool CanPlayCard(Card c)
		{
			return c.getColor().Equals(topCard.getColor()) ||
						c.getType().Equals(topCard.getType()) ||
						c.getColor().Equals("") ||
						topCard.getColor().Equals("");
		}

}
