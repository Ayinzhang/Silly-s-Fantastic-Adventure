using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prickle : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player"&&Player.lv>0)
        transform.Find("Prickles").gameObject.SetActive(true);
    }
}
