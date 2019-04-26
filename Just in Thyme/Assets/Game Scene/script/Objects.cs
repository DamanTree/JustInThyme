using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Objects : MonoBehaviour
{

    public Button summertree, autumntree, wintertree;
    public Text clicked;
    private int week;
    private string objectclicked;


    void Update()
    {
        week = PlayerPrefs.GetInt("current") % 52;

        objectclicked = PlayerPrefs.GetString("object");

        if (objectclicked == "tree")
        {
            if (week > 0 && week <= 26)
            {
                summertree.gameObject.SetActive(true);
                autumntree.gameObject.SetActive(false);
                wintertree.gameObject.SetActive(false);
                PlayerPrefs.SetString("tree", "summer");
            }
            else if (week > 26 && week <= 39)
            {
                summertree.gameObject.SetActive(false);
                autumntree.gameObject.SetActive(true);
                wintertree.gameObject.SetActive(false);
                PlayerPrefs.SetString("tree", "autumn");
            }
            else if (week > 39 && week <= 52)
            {
                summertree.gameObject.SetActive(false);
                autumntree.gameObject.SetActive(false);
                wintertree.gameObject.SetActive(true);
                PlayerPrefs.SetString("tree", "winter");
            }
        }

    }

    public void clicktree()
    {
        PlayerPrefs.SetString("object", "tree");
        clicked.text = "tree";
    }

    public void Reset()
    {
        PlayerPrefs.SetString("object", "none");
        clicked.text = "noobject";
    }
}
