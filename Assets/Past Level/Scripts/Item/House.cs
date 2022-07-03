using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class House : MonoBehaviour
{
    bool isDoor = false;

    void Update()
    {
        if(isDoor&&Input.GetKeyDown(KeyCode.W))
        {
            Save.lv = Player.lv; Player.jumpTime = Save.jumpTime;
            if (SceneManager.GetActiveScene().name == "Past Level") SceneManager.LoadScene("Present Level");
            else if (SceneManager.GetActiveScene().name == "Present Level") SceneManager.LoadScene("End Menu");
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player") isDoor = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player") isDoor = false;
    }
}
