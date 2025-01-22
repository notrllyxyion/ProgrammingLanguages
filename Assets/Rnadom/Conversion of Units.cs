using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConversionofUnits : MonoBehaviour
{
    public float PHP;
    public float Dollars;
    public float Yen;
    public float KoreanWon;
    public float Euros;
    public float Pounds;

    public TMP_InputField inputField;
    public TextMeshProUGUI convertedValue;

    public void ToDollars()
    {
        string inputvalue = inputField.text;
        float numericValue;
        if (float.TryParse(inputvalue, out numericValue))
        {
            Debug.Log(numericValue);
            PHP = numericValue * Dollars;
            convertedValue.text = "₱" + PHP.ToString();
        }   
        else
        {
            Debug.Log("invalid Input");
        }
    }
    public void ToYen()
    {
        string inputvalue = inputField.text;
        float numericValue;
        if (float.TryParse(inputvalue, out numericValue))
        {
            Debug.Log(numericValue);
            PHP = numericValue * Yen;
            convertedValue.text = "₱" + PHP.ToString();
        }
        else
        {
            Debug.Log("invalid Input");
        }
    }
    public void ToWon()
    {
        string inputvalue = inputField.text;
        float numericValue;
        if (float.TryParse(inputvalue, out numericValue))
        {
            Debug.Log(numericValue);
            PHP = numericValue * KoreanWon;
            convertedValue.text = "₱" + PHP.ToString();
        }
        else
        {
            Debug.Log("invalid Input");
        }
    }
    public void ToPounds()
    {
        string inputvalue = inputField.text;
        float numericValue;
        if (float.TryParse(inputvalue, out numericValue))
        {
            Debug.Log(numericValue);
            PHP = numericValue * Pounds;
            convertedValue.text = "₱" + PHP.ToString();
        }
        else
        {
            Debug.Log("invalid Input");
        }
    }
    public void ToEuros()
    {
        string inputvalue = inputField.text;
        float numericValue;
        if (float.TryParse(inputvalue, out numericValue))
        {
            Debug.Log(numericValue);
            PHP = numericValue * Euros;
            convertedValue.text = "₱" + PHP.ToString();
        }
        else
        {
            Debug.Log("invalid Input");
        }
    }
}
