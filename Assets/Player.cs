using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] Canvas viewCanvas;
    [SerializeField] CardSlot viewSlot;
    [Range(0.05f,1f)]
    [SerializeField] float cardSpeed = 1;

    Card currentCard;
    
    void Start()
    {
        RegisterForMouseEvents();
    }

    void Update()
    {
        if (currentCard)
        {
            SetCardToMousePosition();
            if (Input.GetMouseButtonUp(0))
            {
                StopAllCoroutines();
                StartCoroutine(MoveOverTime(currentCard, currentCard.GetHomeLocation(), cardSpeed));
                Cursor.visible = true;
                currentCard = null;
            }
        }
    }

    private void RegisterForMouseEvents()
    {
        var cameraRaycaster = Camera.main.GetComponent<CameraRaycaster>();
        cameraRaycaster.onMouseOverCard += OnMouseOverCard;
    }

    private void SetCardToMousePosition()
    {
        Vector3 cardPos = currentCard.transform.position;
        cardPos.x = GetMouseXAndZ().x;
        cardPos.y = 0.5f; // TODO get rid of magic number
        cardPos.z = GetMouseXAndZ().y;
        currentCard.transform.position = cardPos;
    }

    private void OnMouseOverCard(Card card)
    {
        // Debug.Log("Mouse over card: " + card.name);
        if (Input.GetMouseButtonDown(1))
        {
            //print("You picked up " + card.name + ".");
            if (card.transform.position == card.GetHomeLocation() && viewSlot.IsOccupied() == false)
            {
                viewSlot.SetCurrentCard(card);
                StartCoroutine(MoveCard(viewSlot.transform.position));
                viewCanvas.gameObject.SetActive(true);
            }
            else { return; }
        }
        if (Input.GetMouseButtonDown(0))
        {
            currentCard = card;
            Cursor.visible = false;
        }
    }

    public IEnumerator MoveCard(Vector3 target)
    {
        StopAllCoroutines();
        StartCoroutine(MoveOverTime(viewSlot.GetCurrentCard(), target, cardSpeed));
        yield return new WaitForSeconds(cardSpeed);
    }

    public void CloseViewWindow()
    {
        viewCanvas.gameObject.SetActive(false);
    }

    public void ReturnCard()
    {
        StopAllCoroutines();
        StartCoroutine(MoveOverTime(viewSlot.GetCurrentCard(), viewSlot.GetCurrentCard().GetHomeLocation(), cardSpeed));
        viewSlot.ClearCurrentCard();
    }

    public IEnumerator MoveOverTime(Card cardToMove, Vector3 end, float seconds)
    {
        float elapsedTime = 0;
        Vector3 startingPos = cardToMove.transform.position;
        while (elapsedTime < seconds)
        {
            cardToMove.transform.position = Vector3.Lerp(startingPos, end, (elapsedTime / seconds));
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        cardToMove.transform.position = end;
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
