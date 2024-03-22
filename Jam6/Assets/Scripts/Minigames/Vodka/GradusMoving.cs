using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class GradusMoving : MonoBehaviour
{
    public float speed = 100;

    float maxY = 459;
    float minY = 122;

    private void Update()
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
    void FixedUpdate()
    {
        float randomNumber = UnityEngine.Random.value % 2;
        if(randomNumber == 0)
        {
            speed *= -1;
        }
    }
}
