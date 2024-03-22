using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using UnityEngine;

public class BuffSystem : MonoBehaviour
{
    public static bool Buff;
    public static bool isBuffReady = false;
    public static void BuffSpeed(float time)
    {
        if(isBuffReady)
        {
            Debug.Log("Buff started");
            if (time > 0)
            {
                Buff = true;
                //Control.speed*=1.3f;
                time -= Time.deltaTime;
                Debug.Log(time);
            }
            else 
            {
                Buff = false;
                Debug.Log("Speed buff end");
                isBuffReady = false;
            }
        }

    }

    private void Update() {
        //BuffSpeed(5f);
    }

}
