using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("Card Game/Ability Card"))]
public class AbilityConfig : CardConfig {

    [SerializeField] string uniqueAbility;  //TODO Change name to unique name

    public override CardBehavior GetBehaviorComponent (GameObject objectToAttachTo)
    {
        return objectToAttachTo.AddComponent<AbilityBehavior>();
    }

    public string GetUniqueAbility() { return uniqueAbility; }
}
