using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    public static int counter = 0;
    public GameObject minigame;

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
                    // ты выиграл выдаётся баф
                    Destroy(minigame);
                }
            }
            else
            {
                // ты проиграл, выдаётся дебаф
                Destroy(minigame);
            }

            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
