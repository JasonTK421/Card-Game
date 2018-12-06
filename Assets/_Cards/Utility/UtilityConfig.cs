using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("Card Game/Utility Card"))]
public class UtilityConfig : CardConfig {

    static string CardType = "UTILITY";
    enum UtilityClass { Ring, Amulet, Potion};

    [Header("Gear Spacific")]
    [SerializeField] UtilityClass utilityClass;

    public override CardBehavior GetBehaviorComponent(GameObject objectToAttachTo)
    {
        return objectToAttachTo.AddComponent<UtilityBehavior>();
    }

    public string GetCardType() { return CardType; }
    public string GetUtilityClass() { return utilityClass.ToString(); }
}
