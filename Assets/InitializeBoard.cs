using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeBoard : MonoBehaviour
{
    Player player;
    Card[] playerDeck;
    CardSlot[] cardSlots;
    
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        playerDeck = player.GetDeckOfCards();
        cardSlots = FindObjectsOfType<CardSlot>();
        //Debug.Log("Number of cardSlots should be 14.");
        //Debug.Log("Number of cardSlots actually is: " + cardSlots.Length);

        //Debug.Log("Cards in playerDeck on InitializeBoard.cs: ");
        //foreach (Card card in playerDeck)
        //{
        //    Debug.Log(card);
        //}
        
        foreach (Card card in playerDeck)
        {
            //Debug.Log(card);
            int i = 0;
            foreach (CardSlot cardSlot in cardSlots)
            {
                //Debug.Log("Card cardType: " + card.GetCardType());
                if ((card.GetCardType() == cardSlot.GetCardType()) && !cardSlot.IsOccupied())
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
