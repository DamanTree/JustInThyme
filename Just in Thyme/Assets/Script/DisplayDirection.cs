using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayDirection : MonoBehaviour
{

    public Button toggle;

    public Text display;

    [HideInInspector] public int direction;

    void Start()
    {
        display.text = "To the Future";
        direction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (toggle.enabled)
        {
            display.text = "To the Future";
            direction = 1;
        }
        else
        {
            display.text = "To the Past";
            direction = -1;
        }
    }
}
