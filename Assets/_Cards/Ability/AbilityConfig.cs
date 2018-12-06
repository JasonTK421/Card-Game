using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("Card Game/Ability Card"))]
public class AbilityConfig : CardConfig {

    static string CardType = "ABILITY";

    public override CardBehavior GetBehaviorComponent (GameObject objectToAttachTo)
    {
        return objectToAttachTo.AddComponent<AbilityBehavior>();
    }

    public string GetCardType () { return CardType; }
}
