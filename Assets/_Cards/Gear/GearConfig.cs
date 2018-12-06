using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("Card Game/Gear Card"))]
public class GearConfig : CardConfig {

    static string CardType = "GEAR";
    enum ArmorClass { Head, Arms, Chest, Hands, Weapon1, Weapon2, Legs, Feet };

    [Header("Gear Spacific")]
    [SerializeField] ArmorClass armorClass;
    [SerializeField] float maxAttack;
    [SerializeField] float maxDefence;

    public override CardBehavior GetBehaviorComponent (GameObject objectToAttachTo)
    {
        return objectToAttachTo.AddComponent<GearBehavior>();
    }

    public string GetCardType() { return CardType; }
    public string GetArmorClass() { return armorClass.ToString(); }
    public float GetMaxAttack() { return maxAttack; }
    public float GetMaxDefence() { return maxDefence; }
}
