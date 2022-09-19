using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_New : MonoBehaviour
{
    public void OnClick()
    {
        Save.lv = 0;Save.jumpTime = 1;
        SceneManager.LoadScene("Past Level");
    }
}
