using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

    [Header("Menu Buttons")]
    public Button EditBtn;
    public Button HelpBtn;
    public Button AboutBtn;
    public Button ExitBtn;

    [Header("Text")]
    public Text CPText;
    public Text SPText;
    public Text EPText;
    public Text GPText;
    public Text PPText;

    [Header("Panels")]
    public GameObject EditPanel;
    public GameObject HelpPanel;
    public GameObject AboutPanel;

    [Header("Back Buttons")]
    public Button EditPanelBack;
    public Button HelpPanelBack;
    public Button AboutPanelBack;   

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
