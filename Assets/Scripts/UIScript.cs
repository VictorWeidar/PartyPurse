using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour {

    Calculator _calculator;

    [Header("Menu Buttons")]
    public Button EditBtn;
    public Button HelpBtn;
    public Button AboutBtn;
    public Button ExitBtn;
    public Button ResetBtn;

    [Header("Text")]
    public Text CPText;
    public Text SPText;
    public Text EPText;
    public Text GPText;
    public Text PPText;

    [Header("Integers")]
    public int CPTotal;
    public int SPTotal;
    public int EPTotal;
    public int GPTotal;
    public int PPTotal;

    [Header("Panels")]
    public GameObject EditPanel;
    public GameObject HelpPanel;
    public GameObject AboutPanel;
    public GameObject SecurityPanel;
    public GameObject WarningPanel;

    [Header("Security Panel")]
    public Button YesButton;
    public Button NoButton;

    [Header("Warning Panel")]
    public Button OKBtn;

    [Header("Back Buttons")]
    public Button EditPanelBack;
    public Button HelpPanelBack;
    public Button AboutPanelBack;   

	// Use this for initialization
	void Start ()
    {
        _calculator = GetComponent<Calculator>();

        CPTotal = PlayerPrefs.GetInt("CopperTotal", 0);
        SPTotal = PlayerPrefs.GetInt("SilverTotal", 0);
        EPTotal = PlayerPrefs.GetInt("ElektrumTotal", 0);
        GPTotal = PlayerPrefs.GetInt("GoldTotal", 0);
        PPTotal = PlayerPrefs.GetInt("PlatinumTotal", 0);
    }
	
	// Update is called once per frame
	void Update ()
    {
        CPText.text = CPTotal.ToString();
        SPText.text = SPTotal.ToString();
        EPText.text = EPTotal.ToString();
        GPText.text = GPTotal.ToString();
        PPText.text = PPTotal.ToString();
    }

    public void OnButtonEdit()
    {
        EditPanel.SetActive(true);
    }

    public void OnButtonAbout()
    {
        AboutPanel.SetActive(true);
    }

    public void OnButtonHelp()
    {
        HelpPanel.SetActive(true);
    }

    public void OnBack()
    {
        EditPanel.SetActive(false);
        HelpPanel.SetActive(false);
        AboutPanel.SetActive(false);

        _calculator.OnButtonClear();
    }

    public void OnReset()
    {
        SecurityPanel.SetActive(true);
    }

    public void OnExit()
    {
        Application.Quit();
    }

    public void OnNo()
    {
        SecurityPanel.SetActive(false);
    }

    public void OnYes()
    {
        SecurityPanel.SetActive(false);

        PlayerPrefs.SetInt("CopperTotal", 0);
        PlayerPrefs.SetInt("SilverTotal", 0);
        PlayerPrefs.SetInt("ElektrumTotal", 0);
        PlayerPrefs.SetInt("GoldTotal", 0);
        PlayerPrefs.SetInt("PlatinumTotal", 0);

        SceneManager.LoadScene(0);
    }

    public void OnOK()
    {
        WarningPanel.SetActive(false);
    }
}
