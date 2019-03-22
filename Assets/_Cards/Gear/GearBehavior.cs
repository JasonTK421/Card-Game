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
        gameObject.GetComponent<Card>().nameText.text = nameToDisplay;

        Sprite imageToDisplay = (cardConfig as GearConfig).GetSprite();
        gameObject.GetComponent<Card>().image.sprite = imageToDisplay;

        string descriptionToDisplay = (cardConfig as GearConfig).GetDescription();
        gameObject.GetComponent<Card>().descriptionText.text = descriptionToDisplay;

        string abilityToDisplay = (cardConfig as GearConfig).GetUniqueAbility();
        gameObject.GetComponent<Card>().uniqueAbilityText.text = abilityToDisplay;

        CardType typeToDisplay = (cardConfig as GearConfig).GetCardType();
        gameObject.GetComponent<Card>().typeText.text = typeToDisplay.ToString();

        string classToDisplay = (cardConfig as GearConfig).GetArmorClass();
        gameObject.GetComponent<Card>().classText.text = classToDisplay;

        float attackToDisplay = (cardConfig as GearConfig).GetMaxAttack();
        gameObject.GetComponent<Card>().attackText.text = attackToDisplay.ToString();

        float defenceToDisplay = (cardConfig as GearConfig).GetMaxDefence();
        gameObject.GetComponent<Card>().defenceText.text = defenceToDisplay.ToString();
    }
}
