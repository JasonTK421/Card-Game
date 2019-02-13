using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    ViewSlot viewSlot;
    Card currentCard;
    
    void Start()
    {
        viewSlot = FindObjectOfType<ViewSlot>();
        RegisterForMouseEvents();
    }

    void Update()
    {
        if (currentCard)
        {
            SetCardToMousePosition();
            if (Input.GetMouseButtonUp(0))
            {
                currentCard.transform.position = currentCard.GetHomeLocation();
                Cursor.visible = true;
                currentCard = null;
            }
        }
    }

    private void SetCardToMousePosition()
    {
        Vector3 cardPos = currentCard.transform.position;
        cardPos.x = GetMouseXAndZ().x;
        cardPos.y = 0.5f; // TODO get rid of magic number
        cardPos.z = GetMouseXAndZ().y;
        currentCard.transform.position = cardPos;
    }

    private void RegisterForMouseEvents()
    {
        var cameraRaycaster = Camera.main.GetComponent<CameraRaycaster>();
        cameraRaycaster.onMouseOverCard += OnMouseOverCard;
    }

    private void OnMouseOverCard(Card card)
    {
        // Debug.Log("Mouse over card: " + card.name);
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
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Grabed: " + card.name);
            currentCard = card;
            Cursor.visible = false;
        }
    }

    Vector2 GetMouseXAndZ()
    {
        Vector2 XZpoints;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        XZpoints.x = ray.GetPoint(9.5f).x;
        XZpoints.y = ray.GetPoint(9.5f).z;

        return XZpoints;
    }
}
