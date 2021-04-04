using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList =
        { "sidewalk", "robin", "three", "pizzas", "thoughtless", "thought", "comb", "shrub", "fence",
            "pedestrian", "crosswalk", "hamburgers", "fies", "soda", "shrimp", "clam", "egg" , "bacon",
            "pig", "cow", "dog", "catch", "fish", "hog", "owl", "leopard", "tiger", "lion", "chicken",
            "spongebob", "patrick", "squidward", "hawk", "eagle", "fourty-five", "backpack", "pencils",
            "paper", "doodle-bob", "scarce", "spare", "ablaze", "ninja", "combat", "boots", "jacket" };

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
