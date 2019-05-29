using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour {

    [SerializeField] CardConfig cardConfig;

    [Header("Display Fields")]
    public Text displayName;
    public Image displaImage;
    public Text displayDescription;
    public Text displayType;
    public Text displayClass;
    public Text displayAbillity;
    public Text displayAttack;
    public Text displayDefence;

    [SerializeField] float maxAttack; // TODO remove [SerializeField]
    [SerializeField] float attack;
    [SerializeField] float maxDefence; // TODO remove [SerializeField]
    [SerializeField] float defence;
    [SerializeField] Card target;

    Vector3 homeLocation;

    public void SetCardConfig(CardConfig cardconfig) { cardConfig = cardconfig; }
    public void SetHomeLocation(Vector3 location) { homeLocation = location;  }
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
        attack = maxAttack;
        defence = maxDefence;
        homeLocation = transform.position;
    }
    void Update()
    {
        displayAttack.text = attack.ToString();
        displayDefence.text = defence.ToString();
    }

    public Vector3 GetHomeLocation()
    {
        return homeLocation;
    }
    public void SetMaxAttack(float attack)
    {
        maxAttack = attack;
    }
    public void SetMaxDefence(float defence)
    {
        maxDefence = defence;
    }

    public float GetAttack()
    {
        return attack;
    }
    public void SetAttack(float attack)
    {
        this.attack = attack;
    }

    public float GetDefence()
    {
        return defence;
    }
    public void SetDefence(float defence)
    {
        this.defence = defence;
    }

    public bool HasTarget()
    {
        if (target != null) return true;
        else return false;
    }
    public Card GetTarget()
    {
        return target;
    }
}
