using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayWeeksNum : MonoBehaviour
{
    public Slider slider;

    public Text display;

    // Update is called once per frame
    void Update()
    {
        slider.onValueChanged.AddListener(OnValueChange);
    }

    public void OnValueChange(float value)
    {
        display.text = "Weeks: " + value.ToString();
    }
}
