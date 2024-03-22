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

    public GameObject ErrorTXT;
    void Start()
    {
        cnvs.SetActive(true);

        IpAddressField.onValueChanged.AddListener(IpValueChanged);

        RndIP = Random.Range(100000000, 999999999);

        TxtWithIP.text = RndIP.ToString("### ### ###").Replace(" ", ".");
    }

    public void Click()
    {
        if(TxtWithIP.text == IpAddressField.text)
        {
            cnvs.SetActive(false);
            ErrorTXT.SetActive(false);
        }
        else
        {
            ErrorTXT.SetActive(true);
            IpAddressField.text = "";
        }
    }

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
