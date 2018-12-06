using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("Card Game/Hero Card"))]
public class HeroConfig : CardConfig {

    static string CardType = "HERO";

    [Header("Hero Spacific")]
    [SerializeField] string heroClass;
    [SerializeField] float maxAttack;
    [SerializeField] float maxDefence;

    public override CardBehavior GetBehaviorComponent(GameObject objectToAttachTo)
    {
        return objectToAttachTo.AddComponent<HeroBehavior>();
    }

    public string GetCardType() { return CardType; }
    public string GetHeroClass () { return heroClass; }
    public float GetMaxAttack() { return maxAttack; }
    public float GetMaxDefence() { return maxDefence; }
}
