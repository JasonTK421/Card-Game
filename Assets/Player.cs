using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Card[] playerDeck;

    public Card[] GetDeckOfCards() { return playerDeck; }
}
