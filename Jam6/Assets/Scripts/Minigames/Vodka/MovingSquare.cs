using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovingSquare : MonoBehaviour
{
    bool progressIsGo;
    float progress = 50;
    int progressSpeed = 1;
    private float jumpForce = 0.5f;
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
                Debug.Log(progress);
            }
            else if(progress < 100)
            {
                progress += progressSpeed * Time.deltaTime;
                Debug.Log(progress);
            }
            else
            {
                Debug.Log("Krasava");
                Debug.Log(progress);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        progressIsGo = false;
    }
}
