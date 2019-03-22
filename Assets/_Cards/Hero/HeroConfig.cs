using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("Card Game/Hero Card"))]
public class HeroConfig : CardConfig {

    [Header("Hero Spacific")]
    [SerializeField] string heroClass;
    [SerializeField] float maxAttack;
    [SerializeField] float maxDefence;
    [SerializeField] string uniqueAbility;  //TODO Change name to unique name

    public override CardBehavior GetBehaviorComponent(GameObject objectToAttachTo)
    {
        return objectToAttachTo.AddComponent<HeroBehavior>();
    }

    public string GetHeroClass () { return heroClass; }
    public float GetMaxAttack() { return maxAttack; }
    public float GetMaxDefence() { return maxDefence; }
    public string GetUniqueAbility() { return uniqueAbility; }
}
