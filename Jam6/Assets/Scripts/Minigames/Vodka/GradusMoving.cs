using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradusMoving : MonoBehaviour
{
    public float speed = 100;
    public float minHeight = 0;
    public float maxHeight = 166;

    private void Update()
    {
        float randomYPosition = Random.Range(-270, 270);
        transform.position = new Vector3(transform.position.x, randomYPosition, transform.position.z);

    }
}
