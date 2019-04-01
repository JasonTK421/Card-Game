using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroBehavior : CardBehavior {

    public override void Use ()
    {
        throw new System.NotImplementedException();
    }

    public override void DisplayInfo(GameObject gameObject)
    {
        string nameToDisplay = (cardConfig as HeroConfig).GetCardName();
        gameObject.GetComponent<Card>().nameText.text = nameToDisplay;

        Sprite imageToDisplay = (cardConfig as HeroConfig).GetSprite();
        gameObject.GetComponent<Card>().image.sprite = imageToDisplay;

        string descriptionToDisplay = (cardConfig as HeroConfig).GetDescription();
        gameObject.GetComponent<Card>().descriptionText.text = descriptionToDisplay;

        string abilityToDisplay = (cardConfig as HeroConfig).GetUniqueAbility();
        gameObject.GetComponent<Card>().uniqueAbilityText.text = abilityToDisplay;

        CardClass typeToDisplay = (cardConfig as HeroConfig).GetCardClass();
        gameObject.GetComponent<Card>().typeText.text = typeToDisplay.ToString();

        string classToDisplay = (cardConfig as HeroConfig).GetHeroClass();
        gameObject.GetComponent<Card>().classText.text = classToDisplay;

        float attackToDisplay = (cardConfig as HeroConfig).GetMaxAttack();
        gameObject.GetComponent<Card>().attackText.text = attackToDisplay.ToString();

        float defenceToDisplay = (cardConfig as HeroConfig).GetMaxDefence();
        gameObject.GetComponent<Card>().defenceText.text = defenceToDisplay.ToString();
    }

}
