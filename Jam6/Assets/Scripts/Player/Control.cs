using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] float speed = 5f;
    private Vector3 movevector;
    

    public static bool ButtonClickedE;

    private void Awake() 
    {
        rb = GetComponent<Rigidbody>();   
        sr = GetComponentInChildren<SpriteRenderer>(); 
    }
    private void Update() 
    {
        Walk();
        CheckForInteract();
        Flip();
    }

    void Walk() //Простая механика ходьбы через инпуты
    {
        movevector.x = Input.GetAxisRaw("Horizontal");
        movevector.z = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector3(movevector.x * speed, 0 , movevector.z * speed);
    }
    
    private bool FaceRight = false;
    void Flip()
    {
        if(movevector.x < 0)
        {
            sr.flipX = true;
        }
        else if(movevector.x > 0)
        {
            sr.flipX = false;
        }
    }

    public void CheckForInteract()//Проверка на взаимодействие
    {
        if(InteractTrigger.PlayerInRange)//Если мы в зоне взаимодействия
        {
            //Строка меняющая объект
            if(Input.GetKeyDown(KeyCode.E))//Если кнопка нажата, обозначаем bool на true 
            {
                ButtonClickedE = true; //Проверка на эту переменную в InterractTrigger
            }
        }
    }
    
}
