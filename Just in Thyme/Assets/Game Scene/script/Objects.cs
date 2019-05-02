using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Objects : MonoBehaviour
{

    public Button summertree, autumntree, wintertree;
    public Button apple, appletree, appleworm;
    public Button sculpture, sculptureraw;
    public Text clicked;
    private int week, tempseason;
    private string objectclicked, season;


    void Update()
    {
        if (PlayerPrefs.GetInt("quest") >= 3)
        {
            SceneManager.LoadScene(2);
        }

        objectclicked = PlayerPrefs.GetString("object");

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

        if (objectclicked == "tree")
        {

            if (season == "spring" || season == "summer")
            {
                summertree.gameObject.SetActive(true);
                autumntree.gameObject.SetActive(false);
                wintertree.gameObject.SetActive(false);
                PlayerPrefs.SetString("tree", "summer");
            }
            else if (season == "autumn")
            {
                summertree.gameObject.SetActive(false);
                autumntree.gameObject.SetActive(true);
                wintertree.gameObject.SetActive(false);
                PlayerPrefs.SetString("tree", "autumn");
            }
            else if (season == "winter")
            {
                summertree.gameObject.SetActive(false);
                autumntree.gameObject.SetActive(false);
                wintertree.gameObject.SetActive(true);
                PlayerPrefs.SetString("tree", "winter");
            }
        }

        if (objectclicked == "apple")
        {

            if (season == "spring")
            {
                appletree.gameObject.SetActive(true);
                apple.gameObject.SetActive(false);
                appleworm.gameObject.SetActive(false);
                PlayerPrefs.SetString("apple", "none");
            }
            else if (season == "summer")
            {
                appletree.gameObject.SetActive(true);
                apple.gameObject.SetActive(true);
                appleworm.gameObject.SetActive(false);
                PlayerPrefs.SetString("apple", "yes");
            }
            else if (season == "autumn")
            {
                appletree.gameObject.SetActive(true);
                apple.gameObject.SetActive(false);
                appleworm.gameObject.SetActive(true);
                PlayerPrefs.SetString("apple", "worm");
            }
            else if (season == "winter")
            {
                appletree.gameObject.SetActive(true);
                apple.gameObject.SetActive(false);
                appleworm.gameObject.SetActive(false);
                PlayerPrefs.SetString("apple", "none");
            }
        }

        if (objectclicked == "sculpture")
        {

            if (season == "summer")
            {
                sculptureraw.gameObject.SetActive(true);
                sculpture.gameObject.SetActive(false);
                PlayerPrefs.SetString("sculpture", "raw");
            }
            else
            {
                sculptureraw.gameObject.SetActive(false);
                sculpture.gameObject.SetActive(true);
                PlayerPrefs.SetString("sculpture", "fixed");
            }
        }
    }

    public void clicktree()
    {
        PlayerPrefs.SetString("object", "tree");
        clicked.text = "tree";
        int num = Random.Range(1, 13);
        PlayerPrefs.SetInt("current", num);
    }

    public void clickapple()
    {
        PlayerPrefs.SetString("object", "apple");
        clicked.text = "apple";
        int num = Random.Range(27, 39);
        PlayerPrefs.SetInt("current", num);
    }

    public void slicksculpture()
    {
        PlayerPrefs.SetString("object", "sculpture");
        clicked.text = "sculpture";
        int num = Random.Range(40, 52);
        PlayerPrefs.SetInt("current", num);
    }

    public void Reset()
    {
        PlayerPrefs.SetString("object", "none");
        clicked.text = "noobject";
    }
}
