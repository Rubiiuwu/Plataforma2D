using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Contador : MonoBehaviour
{
    public static Contador instance;

    public TMP_Text starsText;
    public int currentStars = 0;
    void Start()
    {
        starsText.text = "STARS: " + currentStars.ToString();
    }

    void Awake()
    {
        instance = this;
    }

    public void IncreaseStars(int v)
    {
        currentStars += v;
        starsText.text = "STARS: " + currentStars.ToString();
    }
}
