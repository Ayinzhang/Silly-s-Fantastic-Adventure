using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Title : MonoBehaviour
{
    IEnumerator Scale()
    {
        float x = Random.Range(0.85f, 1.15f), y = Random.Range(0.85f, 1.15f);
        float dx = x - transform.localScale.x, dy = y - transform.localScale.y;
        for (int i = 0; i < 100; i++)
        {
            transform.localScale += new Vector3(dx/100, dy/100, 0); yield return new WaitForSecondsRealtime(0.025f);
        }
        StartCoroutine("Scale");
    }

    IEnumerator Rotate()
    {
        for (int i = 0; i < 100; i++) { transform.Rotate(0, 0, 0.1f); yield return new WaitForSecondsRealtime(0.025f); }
        for (int i = 0; i < 200; i++) { transform.Rotate(0, 0, -0.1f); yield return new WaitForSecondsRealtime(0.025f); }
        for (int i = 0; i < 100; i++) { transform.Rotate(0, 0, 0.1f); yield return new WaitForSecondsRealtime(0.025f); }
        StartCoroutine("Rotate");
    }

    void AudioStart()
    {
        GetComponent<AudioSource>().Play();
    }

    void Start()
    {
        StartCoroutine("Scale"); StartCoroutine("Rotate");
        UI_Announcement.A += AudioStart;
    }
}
