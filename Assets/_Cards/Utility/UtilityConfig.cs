using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("Card Game/Utility Card"))]
public class UtilityConfig : CardConfig {

    [Header("Gear Spacific")]
    [SerializeField] string uniqueAbility;  //TODO Change name to unique name

    public override CardBehavior GetBehaviorComponent(GameObject objectToAttachTo)
    {
        return objectToAttachTo.AddComponent<UtilityBehavior>();
    }

    public string GetUniqueAbility() { return uniqueAbility; }
}
