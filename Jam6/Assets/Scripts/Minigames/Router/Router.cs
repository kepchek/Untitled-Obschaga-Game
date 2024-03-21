using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Router : MonoBehaviour
{

    public GameObject cnvs;

    private int RndIP;
    public TMP_InputField field;
    public TMP_Text TxtWithIP;
    void Start()
    {
        cnvs.SetActive(true);

        RndIP = Random.Range(1000, 5000);

        TxtWithIP.text = RndIP.ToString();
    }

    public void Click()
    {
        if(TxtWithIP.text == field.text)
        {
            cnvs.SetActive(false);
        }
        else Debug.Log("я ебанутый бегите");
    }


}
