using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NPC1 : MonoBehaviour
{

    private string objectname;
    public Text quest;

    private void Start()
    {
        quest.text = "Now that spring has sprung, I miss the autumn aesthetic.\nHelp me to turn turn this tree back to the way it looked";
    }


    void Update()
    {
        objectname = PlayerPrefs.GetString("tree");
        if (objectname == "autumn")
        {
            quest.text = "thanks";
        }
    }
}
