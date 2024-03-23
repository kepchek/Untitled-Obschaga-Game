using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MovingSquare : MonoBehaviour
{

    bool progressIsActive;
    float progress;
    int progressSpeed = 8;
    private float jumpForce = 0.2f;

    public Slider progressSlider;
    void OnEnable()
    {
        progress = 10;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        progressSlider.value = progress;
    }
    void FixedUpdate()
    {
        DoProgress(progressIsActive);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Fish"))
        {
            progressIsActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        progressIsActive = false;
    }

    private void DoProgress(bool progressIsActive)
    {
        if(progressIsActive)
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
        else
        {
            progress -= 0.1f;
            if(progress < 1)
            {
                Debug.Log("Лох твою маму ебали");
                // пользователь поиграл на него накинулся дебаф
            }
        }
    }
}
