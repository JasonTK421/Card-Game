using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckBuilder : MonoBehaviour
{
    [SerializeField] CardConfig[] cardConfigs;
    [SerializeField] Card card;

    // Start is called before the first frame update
    void Start()
    {
        // Instantiate card
        Instantiate(card);
        // attach card config

        // name instance
        // find card slot
        // set transform position to card slot


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
