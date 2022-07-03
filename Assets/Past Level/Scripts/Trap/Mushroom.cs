using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    bool isLeft = false;
    float speed = 6.5f;
    public GameObject leftPoint;
    public GameObject rightPoint;

    void Update()
    {
        if(isLeft) transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        else transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        if (transform.position.x <= leftPoint.transform.position.x) isLeft = false;
        else if (transform.position.x >= rightPoint.transform.position.x) isLeft = true;
        if (transform.position.y < -10) Destroy(gameObject);
    }
}
