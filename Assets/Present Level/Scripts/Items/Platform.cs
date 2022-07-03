using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    float speed = 3.0f;
    float eps = 0.5f;
    int cnt = 1;
    bool isOn = false;
    Vector3 add;
    GameObject player;
    //Transform player_parent;
    public GameObject point1;
    public GameObject point2;
    public GameObject point3;
    public GameObject point4;

    void Start()
    {
        player = GameObject.Find("Player");
        //player_parent = GameObject.Find("Player").transform.parent;
    }

    void Update()
    {
        //Movment
        if (cnt == 1) 
        {
            if (Vector3.Distance(transform.position, point2.transform.position) < eps) cnt = 2;
            else add = speed * Vector3.Normalize(point2.transform.position - transform.position) * Time.deltaTime; 
        }
        else if (cnt == 2)
        {
            if (Vector3.Distance(transform.position, point3.transform.position) < eps) cnt = 3;
            else add = speed * Vector3.Normalize(point3.transform.position - transform.position) * Time.deltaTime;
        }
        else if (cnt == 3)
        {
            if (Vector3.Distance(transform.position, point4.transform.position) < eps) cnt = 4;
            else add = speed * Vector3.Normalize(point4.transform.position - transform.position) * Time.deltaTime;
        }
        else if (cnt == 4)
        {
            if (Vector3.Distance(transform.position, point1.transform.position) < eps) cnt = 1;
            else add = speed * Vector3.Normalize(point1.transform.position - transform.position) * Time.deltaTime;
        }
        transform.position += add;
        if (isOn) player.transform.position += add;

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player")) isOn = true;//other.gameObject.transform.parent = transform;
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player")) isOn = false;//other.gameObject.transform.parent = player_parent;
    }
}
