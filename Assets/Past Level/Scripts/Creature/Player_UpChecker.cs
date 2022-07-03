using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_UpChecker : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        if (!Player.isDead && other.CompareTag("Ground")) Player.isUp = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (!Player.isDead && other.CompareTag("Ground")) Player.isUp = false;
    }
}
