using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NPC3 : MonoBehaviour
{

    private string objectname;
    public Text quest;
    public Button fixedscul, rawscul;
    private bool ischecked = false;

    private void Start()
    {
        quest.text = "I was almost done with my magnificent butter sculpture, but the weather’s still too cold and it’s impossible to carve! Can you make this sculpture easier to carve?";
    }


    void Update()
    {
        objectname = PlayerPrefs.GetString("sculpture");
        if (objectname == "fixed")
        {
            quest.text = "It seems like I still can't use it. It is still too hard";
        }
        else if (objectname == "raw")
        {
            quest.text = "thanks";
            if (!ischecked)
            {
                PlayerPrefs.SetInt("quest", PlayerPrefs.GetInt("quest") + 1);
                ischecked = true;
            }
            fixedscul.interactable = false;
            rawscul.interactable = false;
        }
    }
}
