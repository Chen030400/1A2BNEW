using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonBehavior : MonoBehaviour
{
    [SerializeField] Button BackToMenu;
    [SerializeField] Button Restart;
    [SerializeField] Button Hints;
    [SerializeField] Button SafeMode;
    [SerializeField] Button TimeLimitMode;
    [SerializeField] Button AllLimitMode;
    [SerializeField] Button HardMode;
    [SerializeField] GameObject MainMenu;
    [SerializeField] GameObject Gaming;


    GameObject currentPanel;

    public enum PanelOption
    {
        MainMenu,
        Gaming,
        greeting,
        Ending
    }

    void Start()
    {
        BackToMenu.onClick.AddListener(SwitchMenu);
        SafeMode.onClick.AddListener(SwitchMenu);
        TimeLimitMode.onClick.AddListener(SwitchMenu);
        AllLimitMode.onClick.AddListener(SwitchMenu);
        HardMode.onClick.AddListener(SwitchMenu);
    }

    void Update()
    {
        
    }

    public void SwitchPanel(PanelOption option)
    {

    }

    void SwitchMenu()
    { 

        if (MainMenu.active == false)
        {
            Debug.Log("A open Menu");
            MainMenu.active = true;
            Gaming.active = false;
            Debug.Log("open Menu");
            
        }
        else if (MainMenu.active == true)
        {
            Debug.Log("A Start Game");
            MainMenu.active = false;
            Gaming.active = true;
            Debug.Log("Start Game");
            
        }
        
    }

}
