using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed = 5f;
    private Vector3 movevector;

    private void Start() 
    {
        
    }
    private void Update() 
    {
        Walk();
        CheckForInteract();
    }

    void Walk()
    {
        movevector.x = Input.GetAxisRaw("Horizontal");
        movevector.z = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector3(movevector.x * speed, 0 , movevector.z * speed);
    }

    void CheckForInteract()
    {
        if(InteractTrigger.PlayerInRange)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log(InteractTrigger.MiniGameKey);
            }
        }
    }
    
}
