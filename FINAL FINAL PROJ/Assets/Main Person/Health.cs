using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    Slider healthSlider;
    // Start is called before the first frame update
    void Start()
    {
        healthSlider = GetComponent<Slider>();
    }

    public void decreaseHealth()
    {
        healthSlider.value--; 
    }
}
