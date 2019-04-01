using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = ("Card Game/Ability Card"))]
public abstract class CardConfig : ScriptableObject {

    [Header("Card General")]
    [SerializeField] CardClass cardClass;
    [SerializeField] CardType cardType;
    [SerializeField] string cardName;
    [SerializeField] Sprite image;
    [SerializeField] string description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.";

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

    public CardClass GetCardClass() { return cardClass; }
    public CardType GetCardType() { return cardType; }
    public string GetCardName() { return cardName; }
    public Sprite GetSprite() { return image; }
    public string GetDescription () { return description; }
}

public enum CardClass { HERO, GEAR, UTILITY, ABILITY, VIEW }
public enum CardType { HEAD, ARMS, CHEST, HANDS, WEAPON1, WEAPON2, LEGS, FEET, RING, AMULET, POTION, ABILITY, HERO, VIEW };
