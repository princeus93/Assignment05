using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSettings : MonoBehaviour
{
    public InputField textBox;
    public Slider speedSlider;

    public void saveName()
    {
        PlayerPrefs.SetString("name", textBox.text);
        Debug.Log("Your name is " + PlayerPrefs.GetString("name"));

    }

    public void saveSpeed()
    {
        PlayerPrefs.SetFloat("speed", speedSlider.value);
        Debug.Log("Falling word speed is " + PlayerPrefs.GetFloat("speed"));
    }
}
