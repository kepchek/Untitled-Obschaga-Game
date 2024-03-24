using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Router : MonoBehaviour
{

    public GameObject cnvs;

    private int RndIP;
    public TMP_InputField IpAddressField;
    public TMP_Text TxtWithIP;

    public GameObject MinigameTrigger0; //test........................

    public GameObject ErrorTXT;
    
    public void ExitMinigame0()
    {
        IpAddressField.text = "";
        cnvs.SetActive(false);
        ErrorTXT.SetActive(false);
        MinigameTrigger0.GetComponent<InteractTrigger>().TriggerIsEnabled = false;
    }
    void OnEnable() // когда окно включается генерится новый айпишник
    {
        cnvs.SetActive(true);

        IpAddressField.onValueChanged.AddListener(IpValueChanged);

        RndIP = Random.Range(100000000, 999999999);

        TxtWithIP.text = RndIP.ToString("### ### ###").Replace(" ", ".");

        IpAddressField.Select();
    }

    private void Awake() 
    {
        MinigameTrigger0 = GameObject.Find("MinigameTrigger0");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) // клик работает по энтеру
        {
            Click();
            IpAddressField.Select();
        }
        if(Input.anyKey) // чтобы окно ввода запускалось без клика по нему, но оно не работает так что я хуй знает зачем оно тут существует, но лучше не трогай мало ли что
        {
            IpAddressField.Select();
        }
    }

    public void Click() // проверяет соответствие введённой строки и сгенеренного айпишника
    {
        if(TxtWithIP.text == IpAddressField.text) 
        {
            Scores.ChangeScore(5);
            BuffSystem.isBuffReady = true;
            ExitMinigame0();
        }
        else
        {
            ErrorTXT.SetActive(true);
            Scores.ChangeScore(-5);
            IpAddressField.text = "";
            IpAddressField.Select();
        }
    }

// хуйню ниже не трогай я не ебу как она работает
    private void IpValueChanged(string svalue)
    {
        string snum = System.Text.RegularExpressions.Regex.Replace(svalue, @"[^0-9]", string.Empty) ?? string.Empty;

        if (snum.Length > 9)
        { 
            snum = snum.Substring(0, 9);
        }

        if (snum.Length < 3)
        {
            //
        }
        else if(snum.Length == 3)
        {
            snum = $"{snum}";
        }
        else if (snum.Length <= 6)
        {
            snum = $"{snum.Substring(0, 3)}.{snum.Substring(3, snum.Length - 3)}";
        }
        else if (snum.Length <= 9)
        {
            snum = $"{snum.Substring(0, 3)}.{snum.Substring(3, 3)}.{snum.Substring(6, snum.Length - 6)}";
        }
        IpAddressField.text = snum;
        if (snum.Length != svalue.Length)
        {
            IpAddressField.ForceLabelUpdate();
            IpAddressField.MoveTextEnd(false);
        }

    }


}
