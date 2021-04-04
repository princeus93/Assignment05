using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScreenScript : MonoBehaviour
{
    public Text nameBox;
    public Slider speedSlider;

     void Start()
    {
        nameBox.text = PlayerPrefs.GetString("name");
        speedSlider.value = PlayerPrefs.GetFloat("speed");
    }
}
