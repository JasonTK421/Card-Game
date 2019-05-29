using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    public Card card;

    public void CardBattle()
    {
        if (card.HasTarget())
        {
            Card target = card.GetTarget();

            target.SetDefence(target.GetDefence() - card.GetAttack());
            card.SetDefence(card.GetDefence() - target.GetAttack());
        }
    }
}
