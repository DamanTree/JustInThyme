using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    public GameObject instruction;

    public void changescene()
    {
        PlayerPrefs.SetString("tree", "start");
        PlayerPrefs.SetString("apple", "start");
        PlayerPrefs.SetString("object", "none");
        PlayerPrefs.SetString("sculpture", "start");
        PlayerPrefs.SetInt("quest", 0);
        PlayerPrefs.SetInt("current", 1);
        SceneManager.LoadScene(1);
    }

    public void openinstruction()
    {
        instruction.SetActive(true);
    }

    public void closeinstruction()
    {
        instruction.SetActive(false);
    }
}
