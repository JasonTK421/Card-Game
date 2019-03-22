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
        gameObject.GetComponent<Card>().nameText.text = nameToDisplay;

        Sprite imageToDisplay = (cardConfig as UtilityConfig).GetSprite();
        gameObject.GetComponent<Card>().image.sprite = imageToDisplay;

        string descriptionToDisplay = (cardConfig as UtilityConfig).GetDescription();
        gameObject.GetComponent<Card>().descriptionText.text = descriptionToDisplay;

        string abilityToDisplay = (cardConfig as UtilityConfig).GetUniqueAbility();
        gameObject.GetComponent<Card>().uniqueAbilityText.text = abilityToDisplay;

        CardType typeToDisplay = (cardConfig as UtilityConfig).GetCardType();
        gameObject.GetComponent<Card>().typeText.text = typeToDisplay.ToString();

        string classToDisplay = (cardConfig as UtilityConfig).GetUtilityClass();
        gameObject.GetComponent<Card>().classText.text = classToDisplay;
    }
}
