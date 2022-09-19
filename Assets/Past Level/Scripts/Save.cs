using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Save : MonoBehaviour
{
    public static int jumpTime = 1;
    public static int lv = 0;
    public static string savedScene = "Past Level";

    void Start()
    {
         if (Save.savedScene == "Past Level" && (jumpTime > 2 || Player.jumpTime > 2)) jumpTime = Player.jumpTime = 2;
         else if (Save.savedScene == "Present Level" && (jumpTime > 3 || Player.jumpTime > 3)) jumpTime = Player.jumpTime = 3;
    }
}
