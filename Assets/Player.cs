using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    ViewSlot viewSlot;
    
    void Start()
    {
        viewSlot = FindObjectOfType<ViewSlot>();
        RegisterForMouseEvents();
    }

    private void RegisterForMouseEvents()
    {
        var cameraRaycaster = Camera.main.GetComponent<CameraRaycaster>();
        cameraRaycaster.onMouseOverCard += OnMouseOverCard;
    }

    private void OnMouseOverCard(Card card)
    {
        print("Mouse over card: " + name);
        if (Input.GetMouseButtonDown(1))
        {
            //print("You picked up " + card.name + ".");
            if (card.transform.position == card.GetHomeLocation() && viewSlot.GetIsOccupied() == false)
            {
                viewSlot.SetCurrentCard(card);
                StartCoroutine(viewSlot.OpenViewCanvasAndMoveCard());
            }
            else { return; }
        }
    }
}
