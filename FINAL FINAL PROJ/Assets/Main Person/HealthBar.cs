using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    Slider healthSlider;
    // Start is called before the first frame update
    void Start()
    {
        healthSlider = GetComponent<Slider>();
    }

    public void setHealth(int health)
    {
        healthSlider.value = health;
    }
}
