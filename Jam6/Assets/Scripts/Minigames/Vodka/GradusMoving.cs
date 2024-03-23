using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradusMoving : MonoBehaviour
{
    private float speed = 50f;

    int chance = 100;

    float maxY = 459; // upper limit
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
    private void FixedUpdate()
    {
        if(UnityEngine.Random.Range(50, 5000) <= chance) //change Range to influence on probability
        {
            speed *= -1;
        }
    }
}
