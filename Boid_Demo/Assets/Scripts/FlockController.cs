using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlockController : MonoBehaviour
{
    public float cohesionSTR = 0;
    public float seperationSTR = 0;

    public Slider cSlider;
    public Slider sSlider;

    void Update()
    {
        cohesionSTR = cSlider.value;
        seperationSTR = sSlider.value;
    }

}
