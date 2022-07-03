using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_GroundChecker : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        if (!Player.isDead &&other.CompareTag("Ground")) Player.isGround = true;
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (!Player.isDead && other.CompareTag("Ground")) Player.isGround = false;
        if (!Player.isDead && other.CompareTag("Ladder")) other.isTrigger = false;
    }
}
