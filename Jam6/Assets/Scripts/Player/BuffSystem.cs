using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using UnityEngine;

public class BuffSystem : MonoBehaviour
{
    public static bool Buff; //Переменая проверямая в Control на наличие баффа
    public float time = 5f; //Я хуй знает как сделать кастомное кол-во секунд на бафф
    public static bool isBuffReady = false; //Переменная отвечающая за вкл/выкл баффа
    public void BuffSpeed()
    {
        if(isBuffReady)
        {
            Debug.Log("Buff started");
            if (time > 0)
            {
                Buff = true;
                time -= Time.deltaTime;
                Debug.Log(time);
            }
            else 
            {
                Buff = false;
                Debug.Log("buff end");
                isBuffReady = false;
            }
        }

    }

    private void Update() {
        BuffSpeed();
    }

}
