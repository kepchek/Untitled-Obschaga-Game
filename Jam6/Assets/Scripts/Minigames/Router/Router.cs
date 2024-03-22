using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Router : MonoBehaviour
{

    public GameObject cnvs;

    private int RndIP;
    public TMP_InputField IpAddressField;
    public TMP_Text TxtWithIP;
    void Start()
    {
        cnvs.SetActive(true);

        IpAddressField.onValueChanged.AddListener(IpValueChanged);

        RndIP = Random.Range(1000, 5000);

        TxtWithIP.text = RndIP.ToString("##  (##)");
    }

    public void Click()
    {
        if(TxtWithIP.text == IpAddressField.text)
        {
            cnvs.SetActive(false);
        }
        else Debug.Log("я ебанутый бегите");
    }

    private void IpValueChanged(string svalue)
    {
        string snum = System.Text.RegularExpressions.Regex.Replace(svalue, @"[^0-9]", string.Empty) ?? string.Empty;

        if (snum.Length > 12) snum = snum.Substring(0, 12);

        if (snum.Length < 3)
        {
            //do nothing
        }
        else if(snum.Length == 3)
        {
            snum = $"{snum}";
        }
        else if (snum.Length <= 6)
        {
            snum = $"{snum.Substring(0, 3)}.{snum.Substring(3, snum.Length - 3)}";
        }
        else if (snum.Length <= 10)
        {
            snum = $"{snum.Substring(0, 3)}.{snum.Substring(3, 3)}.{snum.Substring(6, snum.Length - 6)}";
        }
        else {
            snum = $"{snum.Substring(0, 3)}.{snum.Substring(3, 6)}.{snum.Substring(6, 9)}.{snum.Substring(9, snum.Length - 7)}";
        }
        IpAddressField.text = snum;
        if (snum.Length != svalue.Length)
        {
            IpAddressField.ForceLabelUpdate();
            IpAddressField.MoveTextEnd(false);
        }

    }


}
