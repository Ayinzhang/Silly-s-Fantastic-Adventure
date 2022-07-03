using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    bool isLeft = true;
    float speed = 7.5f;
    float eps = 1.0f;
    public GameObject leftPoint;
    public GameObject rightPoint;

    void Destroy()
    {
        Destroy(this.transform.parent.gameObject);
    }

    void Update()
    {
        //Movment
        if (isLeft) transform.position -= new Vector3(Random.Range(speed - eps, speed + eps) * Time.deltaTime, 0, 0);
        else transform.position += new Vector3(Random.Range(speed - eps, speed + eps) * Time.deltaTime, 0, 0);
        if (transform.position.x <= leftPoint.transform.position.x) { isLeft = false; transform.localScale = new Vector3(-1, 1, 1); }
        else if (transform.position.x >= rightPoint.transform.position.x) { isLeft = true; transform.localScale = new Vector3(1, 1, 1); }
    }
}
