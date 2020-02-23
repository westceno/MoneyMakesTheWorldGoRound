using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMoneyText : MonoBehaviour
{

    public Text myText = null;
    // Start is called before the first frame update
    void Start()
    {
        
        if(PlayerPrefs.HasKey("MoneyAmount"))
        {
            myText.text = PlayerPrefs.GetString("MoneyAmount");
        }
        else
        {
            myText.text = "70,000";
        }
    }


}
