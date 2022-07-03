using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    Transform player;
    Rigidbody2D rigidbody2D;

    IEnumerator Attack()
    {
        rigidbody2D.AddForce(new Vector2(0, 1));
        yield return new WaitForSecondsRealtime(0.5f);
        rigidbody2D.velocity = new Vector2(0, 0);rigidbody2D.gravityScale = 0;
        rigidbody2D.AddForce(Mathf.Min(20,(15 + Player.lv)) * new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y));
        yield return new WaitForSecondsRealtime(0.7f);
        rigidbody2D.velocity = new Vector2(0, 0);
        rigidbody2D.AddForce(Mathf.Min(20, (16 + Player.lv)) * new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y));
        yield return new WaitForSecondsRealtime(0.7f);
        rigidbody2D.velocity = new Vector2(0, 0);
        rigidbody2D.AddForce(Mathf.Min(20, (17 + Player.lv)) * new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y));
        yield return new WaitForSecondsRealtime(1.0f);
        Destroy(gameObject);
    }

    void Start()
    {
        player = GameObject.Find("Player").transform;
        rigidbody2D = GetComponent<Rigidbody2D>();
        StartCoroutine("Attack");
    }
}
