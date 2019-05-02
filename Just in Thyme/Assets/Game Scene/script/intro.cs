using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intro : MonoBehaviour
{
    public GameObject introduction;
    // Start is called before the first frame update
    public void clickintro()
    {
        introduction.SetActive(false);
    }
}
