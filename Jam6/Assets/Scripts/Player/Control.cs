using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private Animator anim;
    [SerializeField] float BaseSpeed = 5f; //Установленная неизменяющаяся скорость
    public static float speed; //Скорость установленная на игроке, меняющаяся от баффов/дебаффов
    private Vector3 movevector;
    
    
    public static bool ButtonClickedE;

    private void Awake() 
    {
        rb = GetComponent<Rigidbody>();   
        sr = GetComponentInChildren<SpriteRenderer>(); 
        anim = GetComponentInChildren<Animator>();
        speed = BaseSpeed;

    }
    private void Update() 
    {
        Walk();
        CheckForInteract();
        //CheckForSpeedBuff();
        Flip();
    }

    void Walk() //Простая механика ходьбы через инпуты
    {
        movevector.x = Input.GetAxisRaw("Horizontal");
        movevector.z = Input.GetAxisRaw("Vertical");
        anim.SetFloat("moveX", movevector.x);
        anim.SetFloat("moveZ", movevector.z);
        if(movevector.x == 0)
        {
            anim.SetBool("isMoveX", false);
        }
        else
        {
            anim.SetBool("isMoveX", true);
        }
        if(BuffSystem.Buff)//Ускорение, если бафф активен
        {
            rb.velocity = new Vector3(movevector.x, 0 , movevector.z).normalized*speed*1.3f;
        }
        else
        {
            rb.velocity = new Vector3(movevector.x, 0 , movevector.z).normalized*speed;
        }
    }
    
    void Flip()
    {
        
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
