using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NPC2 : MonoBehaviour
{

    private string objectname;
    public Text quest;
    public Button tree, worm, apple;
    private bool ischecked = false;

    private void Start()
    {
        quest.text = "Help! I accidentally left my apple outside too long and now there are worms in it! Help me to get my apple to back when it didn’t have icky things in it!";
    }


    void Update()
    {
        objectname = PlayerPrefs.GetString("apple");
        if (objectname == "none")
        {
            quest.text = "It seems like there is no apple here for now, try with later season";
        }
        else if (objectname == "yes")
        {
            quest.text = "thanks";
            if (!ischecked)
            {
                PlayerPrefs.SetInt("quest", PlayerPrefs.GetInt("quest") + 1);
                ischecked = true;
            }
            tree.interactable = false;
            apple.interactable = false;
            worm.interactable = false;
        }
        else if (objectname == "worm")
        {
            quest.text = "It seems like there are worms in it";
        }
    }
}
