using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Supermario : MonoBehaviour
{
    AudioSource audio;
    GameObject player;
    public AudioClip bgm;
    public AudioClip supermario;
    public GameObject leftPoint;
    public GameObject rightPoint;

    void Start()
    {
        player = GameObject.Find("Player");
        audio = GameObject.Find("Main Camera").GetComponent<AudioSource>();
    }

    void Update()
    {
        if (leftPoint.transform.position.x <= player.transform.position.x && player.transform.position.x <= rightPoint.transform.position.x)
        { if (audio.clip != supermario) { audio.clip = supermario;audio.Play(); } }
        else { if (audio.clip != bgm) { audio.clip = bgm; audio.Play(); } }
    }
}
