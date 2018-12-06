using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewSlot : MonoBehaviour
{
    [SerializeField] Canvas viewCanvas;
    [SerializeField] bool isOccupied = false;
    [SerializeField] float speed = 1;

    Card currentCard;

    public bool GetIsOccupied() { return isOccupied; }

    public Card GetCurrentCard() { return currentCard; }
    public void SetCurrentCard(Card card) { currentCard = card; isOccupied = true; }
    public void ClearCurrentCard() { currentCard = null; isOccupied = false; }

    public IEnumerator OpenViewCanvasAndMoveCard()
    {
        StopAllCoroutines();
        StartCoroutine(MoveOverTime(currentCard, transform.position, speed));
        yield return new WaitForSeconds(speed);
        viewCanvas.gameObject.SetActive(true);
    }

    public void CloseViewWindowAndReturnCard()
    {
        viewCanvas.gameObject.SetActive(false);
        StopAllCoroutines();
        StartCoroutine(MoveOverTime(currentCard, currentCard.GetHomeLocation(), speed));
        ClearCurrentCard();
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

}
