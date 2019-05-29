using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilityBehavior : CardBehavior {

    public override void Use()
    {
        throw new System.NotImplementedException();
    }

    public override void DisplayInfo(GameObject gameObject)
    {
        string nameToDisplay = (cardConfig as UtilityConfig).GetCardName();
        gameObject.GetComponent<Card>().displayName.text = nameToDisplay;

        Sprite imageToDisplay = (cardConfig as UtilityConfig).GetSprite();
        gameObject.GetComponent<Card>().displaImage.sprite = imageToDisplay;

        string descriptionToDisplay = (cardConfig as UtilityConfig).GetDescription();
        gameObject.GetComponent<Card>().displayDescription.text = descriptionToDisplay;

        string abilityToDisplay = (cardConfig as UtilityConfig).GetUniqueAbility();
        gameObject.GetComponent<Card>().displayAbillity.text = abilityToDisplay;

        CardClass typeToDisplay = (cardConfig as UtilityConfig).GetCardClass();
        gameObject.GetComponent<Card>().displayType.text = typeToDisplay.ToString();

        string classToDisplay = (cardConfig as UtilityConfig).GetCardType().ToString();
        gameObject.GetComponent<Card>().displayClass.text = classToDisplay;
    }
}
