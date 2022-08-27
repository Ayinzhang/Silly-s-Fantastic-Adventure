using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    IEnumerator Destroy()
    {
        yield return new WaitForSecondsRealtime(3f);
        Destroy(gameObject);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player")) { GetComponent<Rigidbody2D>().gravityScale = 1; StartCoroutine("Destroy"); }
    }
}
