using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillHPBar : MonoBehaviour
{
    public float MaxHealth;
    public float Health;

    private Image HealthBarSlider;

    private void Start()
    {
        HealthBarSlider = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        HealthBarSlider.fillAmount = Mathf.Clamp(Health / MaxHealth, 0, 1f);
    }
}
