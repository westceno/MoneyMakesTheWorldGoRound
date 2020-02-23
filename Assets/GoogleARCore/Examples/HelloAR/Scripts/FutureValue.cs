using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FutureValue : MonoBehaviour
{
    public InputField numyears;
    public InputField amt;

    public void LoadAr()
    {
        //PlayerPrefs.SetInt("NumYears", Int32.Parse(numyears.text));
        PlayerPrefs.SetInt("Count", 20);
        amt.text = numyears.text;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private int _frequency;

    public void SelectedFrequency(int index)
    {

    }

    public void update_numyears(String input_text)
    {
    }
}
