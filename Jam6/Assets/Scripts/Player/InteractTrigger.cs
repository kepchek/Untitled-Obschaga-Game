using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractTrigger : MonoBehaviour
{
    [SerializeField] int MiniGameKey;
    public static bool PlayerInRange;
    void Awake() 
    {
        PlayerInRange = false;
    }
    private void Update() 
    {
        ChooseMinigame();
    }

    private void OnTriggerEnter(Collider other) //Игрок вошёл в триггер миниигры
    {
        if(other.gameObject.tag == "Player")
        {
            PlayerInRange = true;
            Debug.Log("Player in range");
        }
    }
    private void OnTriggerExit(Collider other) //Игрок вышел из триггера миниигры
    {
        if(other.gameObject.tag == "Player")
        {
            PlayerInRange = false;
            Debug.Log("Player out of range");
        }
    }

    public void ChooseMinigame()
    {
        if(Control.ButtonClickedE)
        {
            switch(MiniGameKey)//выбираем миниигры по ключу миниигры на объекте-триггере
                {
                    case 0:
                        Debug.Log($"Choose minigame {MiniGameKey}");
                        GameObject.Find("Minigame0").transform.GetChild(0).gameObject.SetActive(true);
                        break;
                    case 1:
                        Debug.Log($"Choose minigame {MiniGameKey}");
                        break;
                    case 2:
                        Debug.Log($"Choose minigame {MiniGameKey}");
                        break;
                }            
        }
        Control.ButtonClickedE = false;

    }

}
