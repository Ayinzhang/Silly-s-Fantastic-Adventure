using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class Cube_Coin : MonoBehaviour
{
    bool isGrey = false;
    public Sprite gley;
    public GameObject coin;
    public AudioClip gem;

    void OnCollisionEnter2D(Collision2D other)
    {
        if(!isGrey && other.gameObject.CompareTag("Player") && other.GetContact(0).normal.y > 0)
        {
            GetComponent<AudioSource>().Play();
            isGrey = true;GetComponent<SpriteRenderer>().sprite = gley;
            Instantiate(coin, transform).GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100));
        }
    }
}
