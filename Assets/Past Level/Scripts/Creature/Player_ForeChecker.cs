using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_ForeChecker : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        if (!Player.isDead && other.CompareTag("Ladder")) other.isTrigger = true;
    }
}
