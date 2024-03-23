using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MovingSquare : MonoBehaviour
{
    float progress = 10;
    int progressSpeed = 8;
    private float jumpForce = 0.2f;

    public Slider progressSlider;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        progressSlider.value = progress;
        if(progress < 1)
        {
            Debug.Log("Лох твою маму ебали");
            // пользователь поиграл на него накинулся дебаф
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Fish"))
        {
            if(progress < 100)
            {
                progress += progressSpeed * Time.deltaTime;
                //Debug.Log(progress);
            }
            else
            {
                Debug.Log("ffff");
                // прользователь победил и на него накидывается какой-то баф
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        progress -= 1;
    }
}
