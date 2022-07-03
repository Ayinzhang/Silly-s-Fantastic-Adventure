using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Mushroom : MonoBehaviour
{
    bool isGrey = false;
    public Sprite gley;
    public GameObject mushroom;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (!isGrey && other.gameObject.CompareTag("Player") && other.GetContact(0).normal.y > 0)
        {
            GetComponent<AudioSource>().Play();
            isGrey = true; GetComponent<SpriteRenderer>().sprite = gley;
            mushroom.SetActive(true);
        }
    }
}
