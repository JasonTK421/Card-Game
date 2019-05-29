using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearBehavior : CardBehavior {

    public override void Use ()
    {
        throw new System.NotImplementedException();
    }

    public override void DisplayInfo (GameObject gameObject)
    {
        string nameToDisplay = (cardConfig as GearConfig).GetCardName();
        gameObject.GetComponent<Card>().displayName.text = nameToDisplay;

        Sprite imageToDisplay = (cardConfig as GearConfig).GetSprite();
        gameObject.GetComponent<Card>().displaImage.sprite = imageToDisplay;

        string descriptionToDisplay = (cardConfig as GearConfig).GetDescription();
        gameObject.GetComponent<Card>().displayDescription.text = descriptionToDisplay;

        string abilityToDisplay = (cardConfig as GearConfig).GetUniqueAbility();
        gameObject.GetComponent<Card>().displayAbillity.text = abilityToDisplay;

        CardClass typeToDisplay = (cardConfig as GearConfig).GetCardClass();
        gameObject.GetComponent<Card>().displayType.text = typeToDisplay.ToString();

        string classToDisplay = (cardConfig as GearConfig).GetCardType().ToString();
        gameObject.GetComponent<Card>().displayClass.text = classToDisplay;

        float attackToDisplay = (cardConfig as GearConfig).GetMaxAttack();
        gameObject.GetComponent<Card>().SetMaxAttack(attackToDisplay);

        float defenceToDisplay = (cardConfig as GearConfig).GetMaxDefence();
        gameObject.GetComponent<Card>().SetMaxDefence(defenceToDisplay);
    }
}
