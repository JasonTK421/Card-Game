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
        gameObject.GetComponent<Card>().displayName.text = nameToDisplay;

        Sprite imageToDisplay = (cardConfig as HeroConfig).GetSprite();
        gameObject.GetComponent<Card>().displaImage.sprite = imageToDisplay;

        string descriptionToDisplay = (cardConfig as HeroConfig).GetDescription();
        gameObject.GetComponent<Card>().displayDescription.text = descriptionToDisplay;

        string abilityToDisplay = (cardConfig as HeroConfig).GetUniqueAbility();
        gameObject.GetComponent<Card>().displayAbillity.text = abilityToDisplay;

        CardClass typeToDisplay = (cardConfig as HeroConfig).GetCardClass();
        gameObject.GetComponent<Card>().displayType.text = typeToDisplay.ToString();

        string classToDisplay = (cardConfig as HeroConfig).GetHeroClass();
        gameObject.GetComponent<Card>().displayClass.text = classToDisplay;

        float attackToCard = (cardConfig as HeroConfig).GetMaxAttack();
        gameObject.GetComponent<Card>().SetMaxAttack(attackToCard);

        float defenceToDisplay = (cardConfig as HeroConfig).GetMaxDefence();
        gameObject.GetComponent<Card>().SetMaxDefence(defenceToDisplay);
    }

}
