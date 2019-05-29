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
        gameObject.GetComponent<Card>().displayName.text = nameToDisplay;

        Sprite imageToDisplay = (cardConfig as AbilityConfig).GetSprite();
        gameObject.GetComponent<Card>().displaImage.sprite = imageToDisplay;

        string descriptionToDisplay = (cardConfig as AbilityConfig).GetDescription();
        gameObject.GetComponent<Card>().displayDescription.text = descriptionToDisplay;

        string abilityToDisplay = (cardConfig as AbilityConfig).GetUniqueAbility();
        gameObject.GetComponent<Card>().displayAbillity.text = abilityToDisplay;

        CardClass typeToDisplay = (cardConfig as AbilityConfig).GetCardClass();
        gameObject.GetComponent<Card>().displayType.text = typeToDisplay.ToString();
    }
}
