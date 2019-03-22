using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("Card Game/Utility Card"))]
public class UtilityConfig : CardConfig {

    enum UtilityClass { Ring, Amulet, Potion};
    
    [Header("Gear Spacific")]
    [SerializeField] UtilityClass utilityClass;
    [SerializeField] string uniqueAbility;  //TODO Change name to unique name

    public override CardBehavior GetBehaviorComponent(GameObject objectToAttachTo)
    {
        return objectToAttachTo.AddComponent<UtilityBehavior>();
    }

    public string GetUtilityClass() { return utilityClass.ToString(); }
    public string GetUniqueAbility() { return uniqueAbility; }
}
