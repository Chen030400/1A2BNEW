using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextNumber : MonoBehaviour
{
    public Text FourDigitsText;

    public void OnButtonClick(int number)
    {
        FourDigitsText.text += number.ToString();
    }
    public void OnClearClick()
    {
        FourDigitsText.text = "";
    }
}
