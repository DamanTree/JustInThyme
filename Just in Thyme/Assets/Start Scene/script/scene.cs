using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetString("tree", "summer");
        PlayerPrefs.SetString("object", "none");
        PlayerPrefs.SetInt("current", 0);
    }
}
