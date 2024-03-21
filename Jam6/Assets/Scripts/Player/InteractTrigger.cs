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

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Player")
        {
            PlayerInRange = true;
            Debug.Log("Player in range");
        }
    }
    private void OnTriggerExit(Collider other) 
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
            switch(MiniGameKey)
                {
                    case(0):
                        Debug.Log($"Choose minigame {MiniGameKey}");
                        break;
                    case(1):
                        Debug.Log($"Choose minigame {MiniGameKey}");
                        break;
                    case(2):
                        Debug.Log($"Choose minigame {MiniGameKey}");
                        break;
                }            
        }
        Control.ButtonClickedE = false;

    }

}
