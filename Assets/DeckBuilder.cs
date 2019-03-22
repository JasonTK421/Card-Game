using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckBuilder : MonoBehaviour
{
    [SerializeField] CardConfig[] cardConfigs;
    [SerializeField] CardSlot[] cardSlots;
    [SerializeField] Card card;

    // Start is called before the first frame update
    void Start()
    {
        cardSlots = FindObjectsOfType<CardSlot>();

        // Instantiate card
        Card newCard = Instantiate(card);
        // attach card config
        newCard.SetCardConfig(cardConfigs[0]);
        // name instance
        newCard.name = newCard.nameText.text;
        // find card slot

        // set transform position to card slot


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
