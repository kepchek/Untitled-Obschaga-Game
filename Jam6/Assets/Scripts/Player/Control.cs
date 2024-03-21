using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed = 5f;
    private Vector2 movevector;

    private void Start() 
    {
        
    }
    private void Update() 
    {

    }

    void Walk()
    {
        movevector.x = Input.GetAxisRaw("Horizontal");
        movevector.y = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(movevector.x * speed, movevector.y * speed);
    }
}
