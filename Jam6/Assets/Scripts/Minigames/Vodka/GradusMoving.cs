using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ну и хули тебе тут объяснять тут всё и так очевидно
public class GradusMoving : MonoBehaviour
{
    private float speed = 50f;

    Vector2 gradusStartPosition;

    int chance = 100;

    float maxY = 459; // верхняя граница в которую уприрается объект
    float minY = 122; // догадайся блять

    void Awake() // запоминаем стартовую позицию
    {
        gradusStartPosition = gameObject.transform.position;
    }

    void OnEnable()
    {
        gameObject.transform.position = gradusStartPosition; // присваиваем стартовую позицию при перезагрузке
    }

    private void Update() // движение этой хуйни
    {
        Vector2 position = gameObject.transform.position;
        position.y += speed*Time.deltaTime;
        transform.position = position;
        if(position.y > maxY)
        {
            speed = -Mathf.Abs(speed);
        }
        if (position.y < minY)
        {
            speed = Mathf.Abs(speed);
        }
    }

    
/*
-Василий Иванович, а отчего это у вас волосы блестят? 
-Петька, это ж я их яйцами натираю 
-Ну акробат!
*/


    private void FixedUpdate() 
    {
        if(UnityEngine.Random.Range(50, 5000) <= chance) // вероятность смены напрвления движения, чем больше второе число тем меньше вероятность, вот и думай.
        {
            speed *= -1;
        }
    }
}
