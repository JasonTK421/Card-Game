using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraRaycaster : MonoBehaviour // TODO maybe Rename Cursor
{

    // TODO use cursorHotspot for visual cursor affordances
    // [SerializeField] Vector2 cursorHotspot = new Vector2(0, 0);

    const int UI_LAYER = 5;
    float maxRaycastDepth = 100f; // Hard coded value

    Rect currentScreenRect;

    // Setup delegates for broadcasting layer changes to other classes
    public delegate void OnMouseOverCard(Card card); // declare new delegate type
    public event OnMouseOverCard onMouseOverCard; // instantiate an observer set

    void Update()
    {
        // TODO fix nullreferenceexception when leaving the current screen
        // hint: I think it is always starting at screen (0,0) not window
        currentScreenRect = new Rect(0, 0, Screen.width, Screen.height);

        // Check if pointer is over an interactable UI element
        if (EventSystem.current.IsPointerOverGameObject())
        {
            // Implement UI interaction
            return; // Stop looking for other objects
        }
        else
        {
            PerformRaycast();
        }
    }

    void PerformRaycast()
    {
        if (currentScreenRect.Contains(Input.mousePosition))
        {
            // Form a ray
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // Specify layer priorities here, order matters
            if (RaycastForCard(ray)) { return; }
        }
    }

    bool RaycastForCard(Ray ray)
    {
        RaycastHit hitInfo;
        Physics.Raycast(ray, out hitInfo, maxRaycastDepth);
        print("hitInfo: " + hitInfo);
        var gameObjectHit = hitInfo.collider.gameObject;
        var cardHit = gameObjectHit.GetComponent<Card>();
        if (cardHit)
        {
            onMouseOverCard(cardHit);
            return true;
        }
        return false;
    }
}
