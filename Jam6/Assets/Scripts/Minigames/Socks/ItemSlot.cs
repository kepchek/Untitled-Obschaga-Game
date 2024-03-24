using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    public static int counter = 0;
    public GameObject minigame;

    public GameObject MinigameTrigger1;

    public void ExitMinigame1()
    {
        counter = 0;
        minigame.SetActive(false);
        MinigameTrigger1.GetComponent<InteractTrigger>().TriggerIsEnabled = false;
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");

        if (eventData.pointerDrag != null)
        {

            GameObject droppedObject = eventData.pointerDrag; // получить объект который скидываешь на платформу

            if (droppedObject.tag == gameObject.tag) // проверка совпадения тега объекта и платформы
            {

                counter++;
                if (counter == 6)
                {
                    Scores.ChangeScore(20);
                    eventData.pointerDrag.GetComponent<CanvasGroup>().blocksRaycasts = true; // почему то полсдений объект при повторном запуске выключал себе эту галочку, другого способа фикса я не нашёл
                    ExitMinigame1();
                }
            }
            else
            {
                // ты проиграл, выдаётся дебаф
                Scores.ChangeScore(-20);
                eventData.pointerDrag.GetComponent<CanvasGroup>().blocksRaycasts = true;
                ExitMinigame1();
            }
            
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
