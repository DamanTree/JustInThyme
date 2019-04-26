using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class watch : MonoBehaviour
{
    public Text changetext, currenttextyear, currenttextweek;
    public Slider changeslider;

    private int year = 0, week = 0;
    private string season;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (week >= 52)
        {
            year += 1;
            week -= 52;
        }
        else if (week < 0)
        {
            year -= 1;
            week = 52 + week;
        }
        currenttextweek.text = "week: " + week;
        currenttextyear.text = "year: " + year;
    }

    public void changeupdate()
    {
        changetext.text = changeslider.value + " weeks";
        PlayerPrefs.SetInt("change", Mathf.RoundToInt(changeslider.value));
    }

    public void futurepressed()
    {
        int temp = PlayerPrefs.GetInt("change");
        week += temp;
        PlayerPrefs.SetInt("current", week);
    }

    public void backpressed()
    {
        int temp = PlayerPrefs.GetInt("change");
        week -= temp;
        PlayerPrefs.SetInt("current", week);
    }
}
