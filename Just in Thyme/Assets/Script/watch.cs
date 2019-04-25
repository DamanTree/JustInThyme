using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class watch : MonoBehaviour
{
    public Text changetext, currenttext;
    public Slider changeslider;

    private int timer = 0;
    private string season;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void changeupdate()
    {
        changetext.text = changeslider.value + " weeks";
        PlayerPrefs.SetInt("change", Mathf.RoundToInt(changeslider.value));
    }

    public void futurepressed()
    {
        int temp = PlayerPrefs.GetInt("change");
        timer += temp;
        currenttext.text = timer + " week";
    }
}
