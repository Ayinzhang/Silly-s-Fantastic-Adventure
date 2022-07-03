using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eagle : MonoBehaviour
{
    bool isUp = true;
    float speed = 8.5f;
    float eps = 1.0f;
    public GameObject upPoint;
    public GameObject downPoint;

    void Destroy()
    {
        Destroy(this.transform.parent.gameObject);
    }

    void Update()
    {
        //Movment
        if (isUp) transform.position += new Vector3(0, Random.Range(speed - eps, speed + eps) * Time.deltaTime, 0);
        else transform.position -= new Vector3(0, Random.Range(speed - eps, speed + eps) * Time.deltaTime, 0);
        if (transform.position.y >= upPoint.transform.position.y)  isUp = false;
        else if (transform.position.y <= downPoint.transform.position.y)  isUp = true;
    }
}
