using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class Cube : MonoBehaviour
{
    bool isGrey = false;
    public Sprite gley;
    public GameObject coin;

    void OnCollisionEnter2D(Collision2D other)
    {
        if(!isGrey && other.gameObject.CompareTag("Player"))
        {
            isGrey = true;GetComponent<SpriteRenderer>().sprite = gley;
            Instantiate(coin, transform);
        }
    }
}
