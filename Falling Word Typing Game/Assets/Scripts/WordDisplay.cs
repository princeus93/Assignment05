using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public float fallSpeed;
    

    public void SetWord(string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }

    public void changeSpeed(float newFallSpeed)
    {
        
        fallSpeed = newFallSpeed;
    }

    public void RemoveWord()
    { 
        Destroy(gameObject); 
    }

    /*public string scoreCount()
    {
        return pointsCount.ToString();
    }*/

    private void Update()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
    }
}
