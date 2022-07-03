using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && !other.gameObject.GetComponent<Animator>().GetBool("IsDead"))
            if (other.GetContact(0).normal.y < -0.9f) Player.onLadder = true;
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && !other.gameObject.GetComponent<Animator>().GetBool("IsDead"))
            Player.onLadder = false;
    }
}
