using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractTrigger : MonoBehaviour
{
    [SerializeField] public static int MiniGameKey = 1;
    public static bool PlayerInRange;
    void Awake() 
    {
        PlayerInRange = false;
    }
    private void Update() 
    {
        
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

}
