using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour {

    [SerializeField] CardConfig cardConfig;

    [Header("Display Fields")]
    public Text nameText;
    public Image image;
    public Text descriptionText;
    public Text typeText;
    public Text classText;
    public Text uniqueAbilityText;
    public Text attackText;
    public Text defenceText;

    Vector3 homeLocation;
    GameObject target;

    public void SetCardConfig(CardConfig cardconfig) { cardConfig = cardconfig; }
    public CardType GetCardType() { return cardConfig.GetCardType(); }

    void Start()
    {
        if (cardConfig != null)
        {
            cardConfig.AttachCardTo(gameObject);
            cardConfig.DisplayInfo(this.gameObject);
        }
        else
        {
            Debug.LogError(name + "'s Card.cs Missing CardConfig!");
        }
        homeLocation = transform.position;
    }

    public Vector3 GetHomeLocation()
    {
        return homeLocation;
    }
}
