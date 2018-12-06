using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityBehavior : CardBehavior {

    public override void Use ()
    {
        throw new System.NotImplementedException();
    }

    public override void DisplayInfo (GameObject gameObject)
    {
        string nameToDisplay = (cardConfig as AbilityConfig).GetCardName();
        gameObject.GetComponent<Card>().nameText.text = nameToDisplay;

        Sprite imageToDisplay = (cardConfig as AbilityConfig).GetSprite();
        gameObject.GetComponent<Card>().image.sprite = imageToDisplay;

        string descriptionToDisplay = (cardConfig as AbilityConfig).GetDescription();
        gameObject.GetComponent<Card>().descriptionText.text = descriptionToDisplay;

        string abilityToDisplay = (cardConfig as AbilityConfig).GetUniqueAbility();
        gameObject.GetComponent<Card>().uniqueAbilityText.text = abilityToDisplay;

        string typeToDisplay = (cardConfig as AbilityConfig).GetCardType();
        gameObject.GetComponent<Card>().typeText.text = typeToDisplay;
    }
}
