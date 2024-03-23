using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.EventSystems;

public class WiresSlot : MonoBehaviour, IDropHandler
{
    public static int counter = 0;
    public GameObject minigame;

    Vector3 originCordsW1 = new Vector3(-434, 163, 0);
    Vector3 originCordsW2 = new Vector3(-434, 6, 0);
    Vector3 originCordsW3 = new Vector3(-434, -150, 0);

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");

        if (eventData.pointerDrag != null)
        {

            GameObject droppedObject = eventData.pointerDrag; // получить объект который скидываешь на платформу

            if (droppedObject.tag == gameObject.tag) // проверка совпадения тега объекта и платформы
            {

                counter++;
                if (counter == 3)
                {
                    counter = 0;
                    minigame.SetActive(false);
                    //eventData.pointerDrag.GetComponent<CanvasGroup>().blocksRaycasts = true; // почему то полсдений объект при повторном запуске выключал себе эту галочку, другого способа фикса я не нашёл
                }
                 droppedObject.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            }
            else
            {
                ReturnWires(droppedObject);
                // counter = 0;
                // minigame.SetActive(false);
                //eventData.pointerDrag.GetComponent<CanvasGroup>().blocksRaycasts = true;
            }
            
            //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }

    private void ReturnWires(GameObject droppedObject)
    {
        switch (droppedObject.tag)
                {
                    case "wires1":
                    droppedObject.GetComponent<RectTransform>().anchoredPosition = originCordsW1;
                    break;
                    case "wires2":
                    droppedObject.GetComponent<RectTransform>().anchoredPosition = originCordsW2;
                    break;
                    case "wires3":
                    droppedObject.GetComponent<RectTransform>().anchoredPosition = originCordsW3;
                    break;
                }
    }
}
