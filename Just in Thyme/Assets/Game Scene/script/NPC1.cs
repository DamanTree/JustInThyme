using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NPC1 : MonoBehaviour
{

    private string objectname;
    public Text quest;
    public Button tree1, tree2, tree3;
    private bool ischecked = false;

    private void Start()
    {
        quest.text = "Now that spring has sprung, I miss the autumn aesthetic.\nHelp me to turn turn this tree back to the way it looked";
    }

    void Update()
    {
        objectname = PlayerPrefs.GetString("tree");
        if (objectname == "summer")
        {
            quest.text = "Try going further in time, but not too far, though!";
        }
        else if (objectname == "autumn")
        {
            quest.text = "thanks";
            if (!ischecked)
            {
                PlayerPrefs.SetInt("quest", PlayerPrefs.GetInt("quest") + 1);
                ischecked = true;
            }

            tree1.interactable = false;
            tree2.interactable = false;
            tree3.interactable = false;
        }
        else if (objectname == "winter")
        {
            quest.text = "Try going further back in time, but not too far, though!";
        }
    }
}
