using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Lode : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene(Save.savedScene);
    }
}
