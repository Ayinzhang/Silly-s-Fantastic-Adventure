using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text_show : MonoBehaviour
{
    public TextMeshProUGUI text;

    IEnumerator Move()
    {
        while(transform.position.y < 324) { transform.position += new Vector3(0, 2f, 0); yield return new WaitForSecondsRealtime(0.03f); }
        yield return new WaitForSecondsRealtime(5f);
        while(transform.position.y < 972) { transform.position += new Vector3(0, 2f, 0); yield return new WaitForSecondsRealtime(0.03f); }
        StartCoroutine("Show");
    }

    IEnumerator Show()
    {
        for (float i = 0; i < 1; i += 0.01f) { text.color = new Vector4(1, 1, 1, i); yield return new WaitForSecondsRealtime(0.03f); } 
    }

    void Start()
    {
        StartCoroutine("Move");
    }
}
