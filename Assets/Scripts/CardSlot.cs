using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSlot : MonoBehaviour
{
    // Used to find Hero Slot Position
    [SerializeField] bool isOccupied = false;
    [SerializeField] CardType cardType;

    Card currentCard;

    public bool IsOccupied() { return isOccupied; }

    public Card GetCurrentCard() { return currentCard; }
    public CardType GetCardType() { return cardType; }
    public void SetCurrentCard(Card card) { currentCard = card; isOccupied = true; }
    public void ClearCurrentCard() { currentCard = null; isOccupied = false; }
}