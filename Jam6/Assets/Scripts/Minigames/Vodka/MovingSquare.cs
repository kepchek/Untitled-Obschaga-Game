using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovingSquare : MonoBehaviour
{
    bool progressIsGo;
    float progress = 0;
    int progressSpeed = 10;
    private float jumpForce = 0.7f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) // Замена KeyCode.Space на вашу кнопку
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Fish"))
        {
            progressIsGo = true;
            if(progress < 1)
            {
                Debug.Log("Pizda");
            }
            else if(progress < 100)
            {
                progress = progressSpeed * Time.deltaTime;
            }
            else
            {
                Debug.Log("Krasava");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        progressIsGo = false;
    }
}
