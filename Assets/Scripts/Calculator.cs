using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Calculator : MonoBehaviour {

    UIScript _UIScript;

    [Header("Variables")]
    public int Number;
    public string NumberText;
    public Text _Numbertext;

    [Header("Numbers")]
    public Button Btn_1;
    public Button Btn_2;
    public Button Btn_3;
    public Button Btn_4;
    public Button Btn_5;
    public Button Btn_6;
    public Button Btn_7;
    public Button Btn_8;
    public Button Btn_9;
    public Button Btn_0;

    public Dropdown _dropdown;
    // Use this for initialization
    void Start ()
    {
        _UIScript = GetComponent<UIScript>();
        
	}

    void Update()
    {
        _Numbertext.text = NumberText;

        if (NumberText.Length > 9)
        {
            _UIScript.WarningPanel.SetActive(true);
            OnButtonClear();
        }
    }

    public void OnButton1()
    {
        NumberText += "1";
    }

    public void OnButton2()
    {
        NumberText += "2";
    }

    public void OnButton3()
    {
        NumberText += "3";
    }

    public void OnButton4()
    {
        NumberText += "4";
    }

    public void OnButton5()
    {
        NumberText += "5";
    }

    public void OnButton6()
    {
        NumberText += "6";
    }

    public void OnButton7()
    {
        NumberText += "7";
    }

    public void OnButton8()
    {
        NumberText += "8";
    }

    public void OnButton9()
    {
        NumberText += "9";
    }

    public void OnButton0()
    {
        NumberText += "0";
    }

    public void OnButtonAdd()
    {

        if (_dropdown.value == 0)
        {
            Number = Convert.ToInt32(NumberText);
            _UIScript.CPTotal += Number;

            Debug.Log("Copper Added: " + Number);

            PlayerPrefs.SetInt("CopperTotal", _UIScript.CPTotal);
        }

        if (_dropdown.value == 1)
        {
            Number = Convert.ToInt32(NumberText);
            _UIScript.SPTotal += Number;

            Debug.Log("Silver Added: " + Number);

            PlayerPrefs.SetInt("SilverTotal", _UIScript.SPTotal);
        }

        if (_dropdown.value == 2)
        {
            Number = Convert.ToInt32(NumberText);
            _UIScript.EPTotal += Number;

            Debug.Log("Elektrum Added: " + Number);

            PlayerPrefs.SetInt("ElektrumTotal", _UIScript.EPTotal);
        }

        if (_dropdown.value == 3)
        {
            Number = Convert.ToInt32(NumberText);
            _UIScript.GPTotal += Number;

            Debug.Log("Gold Added: " + Number);

            PlayerPrefs.SetInt("GoldTotal", _UIScript.GPTotal);
        }

        if (_dropdown.value == 4)
        {
            Number = Convert.ToInt32(NumberText);
            _UIScript.PPTotal += Number;

            Debug.Log("Platinum Added: " + Number);

            PlayerPrefs.SetInt("PlatinumTotal", _UIScript.PPTotal);

        }

        _UIScript.EditPanel.SetActive(false);
        OnButtonClear();
    }

    public void OnButtonSubtract()
    {
        if (_dropdown.value == 0)
        {
            Number = Convert.ToInt32(NumberText);
            _UIScript.CPTotal -= Number;

            Debug.Log("Copper Subtracted: " + Number);

            PlayerPrefs.SetInt("CopperTotal", _UIScript.CPTotal);
        }

        if (_dropdown.value == 1)
        {
            Number = Convert.ToInt32(NumberText);
            _UIScript.SPTotal -= Number;

            Debug.Log("Silver Subtracted: " + Number);

            PlayerPrefs.SetInt("SilverTotal", _UIScript.SPTotal);
        }

        if (_dropdown.value == 2)
        {
            Number = Convert.ToInt32(NumberText);
            _UIScript.EPTotal -= Number;

            Debug.Log("Elektrum Subtracted: " + Number);

            PlayerPrefs.SetInt("ElektrumTotal", _UIScript.EPTotal);
        }

        if (_dropdown.value == 3)
        {
            Number = Convert.ToInt32(NumberText);
            _UIScript.GPTotal -= Number;

            Debug.Log("Gold Subtracted: " + Number);

            PlayerPrefs.SetInt("GoldTotal", _UIScript.GPTotal);
        }

        if (_dropdown.value == 4)
        {
            Number = Convert.ToInt32(NumberText);
            _UIScript.PPTotal -= Number;

            Debug.Log("Platinum Subtracted: " + Number);

            PlayerPrefs.SetInt("PlatinumTotal", _UIScript.PPTotal);
        }

        _UIScript.EditPanel.SetActive(false);
        OnButtonClear();
    }

    public void OnButtonClear()
    {
        NumberText = "";
        Number = 0;
    }
}
