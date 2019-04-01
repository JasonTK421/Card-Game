using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeBoard : MonoBehaviour
{
    Card[] playerDeck;
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        playerDeck = player.GetDeckOfCards();

        Debug.Log("Cards in playerDeck on InitializeBoard.cs: ");
        foreach (Card card in playerDeck)
        {
            Debug.Log(card);
        }
    }
}
