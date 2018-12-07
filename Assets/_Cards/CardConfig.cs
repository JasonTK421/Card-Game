using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = ("Card Game/Ability Card"))]
public abstract class CardConfig : ScriptableObject {

    [Header("Card General")]
    [SerializeField] string cardName;
    [SerializeField] Sprite image;
    [SerializeField] string description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.";
    [SerializeField] string uniqueAbility;

    protected CardBehavior behavior;

    public abstract CardBehavior GetBehaviorComponent(GameObject objectToAttachTo);

    public void AttachCardTo(GameObject gameObjectToAttachTo)
    {
        CardBehavior behaviorComponent = GetBehaviorComponent(gameObjectToAttachTo);
        behaviorComponent.SetConfig(this);
        behavior = behaviorComponent;
    }

    public void DisplayInfo(GameObject gameObject)
    {
        behavior.DisplayInfo(gameObject);
    }

    public string GetCardName() { return cardName; }
    public Sprite GetSprite() { return image; }
    public string GetDescription () { return description; }
    public string GetUniqueAbility () { return uniqueAbility; }
}
