using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckBuilder : MonoBehaviour
{
    [SerializeField] Card card;
    [SerializeField] CardConfig[] cardConfigs;
    [SerializeField] CardSlot[] cardSlots;

    Card[] cards;
    
    // Start is called before the first frame update
    void Start()
    {
        cardSlots = FindObjectsOfType<CardSlot>();

        // resize card array to the length of cardconfigs
        cards = new Card[cardConfigs.Length];

        // Instantiate cards into an array of cards
        for (int i = 0; i < cardConfigs.Length; i++)
        {
            Card newCard = Instantiate(card);
            cards[i] = newCard;
        }

        // attach card config
        for(int i = 0; i < cards.Length; i++)
        {
            cards[i].SetCardConfig(cardConfigs[i]);
        }

        foreach (Card card in cards)
        {
            Debug.Log("card name befor: " + card.name);
            Debug.Log("nameText befor: " + card.nameText.text);
            card.name = card.nameText.text;
            Debug.Log("card name after: " + card.name);
            Debug.Log("nameText after: " + card.nameText.text);
        }

        //// name instance
        //newCard.name = newCard.nameText.text;
        //// find card slot and set transform position to card slot
        //foreach (CardSlot cardSlot in cardSlots)
        //{
        //    if (cardSlot.GetCardType() == newCard.GetCardType())
        //    {
        //        newCard.transform.position = cardSlot.transform.position;
        //    }
        //    else { continue; }
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("card name in update: " + card.name);
        //Debug.Log("nameText in update: " + card.nameText.text);
    }
}
