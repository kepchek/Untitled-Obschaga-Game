using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractTrigger : MonoBehaviour
{
    public bool PlayerInRange;
    void Awake() 
    {
        PlayerInRange = false;
    }
    private void Update() 
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        
    }

}
