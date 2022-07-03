using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_PanelPause : MonoBehaviour
{
    public void OnClick()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);
        Time.timeScale = 1 - Time.timeScale;
    }
}
