using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardBehavior : MonoBehaviour {

    protected CardConfig cardConfig;

    public abstract void Use();

    public abstract void DisplayInfo (GameObject gameObject);

    public void SetConfig (CardConfig configToSet)
    {
        cardConfig = configToSet;
    }
}
