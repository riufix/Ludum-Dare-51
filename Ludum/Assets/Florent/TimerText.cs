using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerText : MonoBehaviour
{
    public float Timer;
    private TextMeshProUGUI Compteur;

    void Start()
    {
        Compteur = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        Compteur.text = Timer.ToString("0.0") + "s";

    }
}
