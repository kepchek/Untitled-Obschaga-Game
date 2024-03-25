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
    [SerializeField]private float jumpForce = 0.2f;

    public GameObject MinigameTrigger2;

    public GameObject Minigame2GameArea;

    public Slider progressSlider;
    void OnEnable()
    {
        progress = 10;
        progressSlider.value = progress;
    }
    private void Awake() 
    {
        MinigameTrigger2 = GameObject.Find("MinigameTrigger2");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) // движение куба вверх вниз
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        progressSlider.value = progress; // слайдер берёт значение (в рот)
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

    private void DoProgress(bool progressIsActive) // проверяет был бы игрок в триггере
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
                Scores.ChangeScore(50);
                ExitMinigame2();
                Debug.Log("Win");
                // прользователь победил и на него накидывается какой-то баф
            }
        }
        else
        {
            progress -= 0.1f;
            // if(progress < 1)
            // {
            //     Scores.ChangeScore(-50);
            //     ExitMinigame2();
            //     Debug.Log("Лох твою маму ебали"); // я принципиально не буду убирать эту строку чтобы все знали что у проигравших матерей ебали
            //     // пользователь поиграл на него накинулся дебаф
            // }
        }
    }

    public void ExitMinigame2()
    {
        Minigame2GameArea.SetActive(false);
        MinigameTrigger2.GetComponent<InteractTrigger>().TriggerIsEnabled = false;
    }
}
