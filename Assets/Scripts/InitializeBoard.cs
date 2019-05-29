using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeBoard : MonoBehaviour
{
    Player[] players;
    //Player player1;
    Card[] player1Deck;
    Card[] player2Deck;
    CardSlot[] cardSlots;
    
    void Start()
    {
        //player1 = GameObject.FindGameObjectWithTag("Player");
        players = FindObjectsOfType<Player>();
        foreach(Player player in players)
        {
            Debug.Log("Looking for players!");
            if (player.tag == "Player")// TODO get rid of string referance
            {
                Debug.Log("Found player 1!");
                player1Deck = player.GetDeckOfCards();
            }
            else if (player.tag == "Player2")
            {
                Debug.Log("Found player 2!");
                player2Deck = player.GetDeckOfCards();
            }
        }
        cardSlots = FindObjectsOfType<CardSlot>();
        //Debug.Log("Number of cardSlots should be 14.");
        //Debug.Log("Number of cardSlots actually is: " + cardSlots.Length);

        //Debug.Log("Cards in playerDeck on InitializeBoard.cs: ");
        //foreach (Card card in playerDeck)
        //{
        //    Debug.Log(card);
        //}

        //PutCardsInCorrectSlots(player1Deck);
        //PutCardsInCorrectSlots(player2Deck);
        foreach (Card card in player1Deck)
        {
            Debug.Log(card);
            int i = 0;
            foreach (CardSlot cardSlot in cardSlots)
            {
                //Debug.Log("Card cardType: " + card.GetCardType());
                if ((card.GetCardType() == cardSlot.GetCardType()) && !cardSlot.IsOccupied() && cardSlot.tag == "Player")
                {
                    Instantiate(card, cardSlot.transform.position, cardSlot.transform.rotation);
                    card.SetHomeLocation(cardSlot.transform.position);
                    cardSlot.SetCurrentCard(card);
                    break;
                }
                i++;
            }
            Debug.Log(i);
        }

        foreach (Card card in player2Deck)
        {
            //Debug.Log(card);
            int i = 0;
            foreach (CardSlot cardSlot in cardSlots)
            {
                //Debug.Log("Card cardType: " + card.GetCardType());
                if ((card.GetCardType() == cardSlot.GetCardType()) && !cardSlot.IsOccupied() && cardSlot.tag == "Player2")
                {
                    Instantiate(card, cardSlot.transform.position, cardSlot.transform.rotation);
                    card.SetHomeLocation(cardSlot.transform.position);
                    cardSlot.SetCurrentCard(card);
                    break;
                }
                i++;
            }
            Debug.Log(i);
        }

    }

    private void PutCardsInCorrectSlots(Card[] deck)
    {
        foreach (Card card in deck)
        {
            //Debug.Log(card);
            int i = 0;
            foreach (CardSlot cardSlot in cardSlots)
            {
                //Debug.Log("Card cardType: " + card.GetCardType());
                if ((card.GetCardType() == cardSlot.GetCardType()) && !cardSlot.IsOccupied() && card.tag == cardSlot.tag)
                {
                    Instantiate(card, cardSlot.transform.position, cardSlot.transform.rotation);
                    card.SetHomeLocation(cardSlot.transform.position);
                    cardSlot.SetCurrentCard(card);
                    break;
                }
                i++;
            }
            Debug.Log(i);
        }
    }
}
