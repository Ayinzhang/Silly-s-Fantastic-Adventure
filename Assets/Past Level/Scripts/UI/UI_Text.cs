using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Text : MonoBehaviour
{
    string s;

    void Start()
    {
        if (Save.savedScene == "Past Level") s = "PST";
        else if (Save.savedScene == "Present Level") s = "PRE";
    }

    void Update()
    {
        GetComponent<Text>().text = "LV:" + Player.lv.ToString() + " - " + s;
    }
}
