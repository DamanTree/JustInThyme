using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class watch : MonoBehaviour
{
    public Text changetext, currenttextyear;
    public Slider changeslider;

    private int year = 0, week = 1, tempseason = 0;
    private string season;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tempseason = PlayerPrefs.GetInt("current") % 52;
        if (tempseason > 0 && tempseason <= 13)
        {
            season = "spring";
        }
        else if (tempseason > 13 && tempseason <= 26)
        {
            season = "summer";
        }
        else if (tempseason > 26 && tempseason <= 39)
        {
            season = "autumn";
        }
        else if (tempseason > 39 && tempseason <= 51)
        {
            season = "winter";
        }
        else if (tempseason == 0)
        {
            season = "winter";
        }
        currenttextyear.text = season;
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
