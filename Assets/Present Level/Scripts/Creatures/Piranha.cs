using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piranha : MonoBehaviour
{
    bool isAttack = false;
    Animator animator;
    BoxCollider2D collider;

    IEnumerator Attack()
    {
        isAttack = true; animator.SetBool("IsAttack", true);
        yield return new WaitForSecondsRealtime(0.2f);
        collider.offset = new Vector2(-0.6303806f, -0.4635739f);
        collider.size = new Vector2(2.207531f, 1.885352f);
        yield return new WaitForSecondsRealtime(0.3f);
        isAttack = false; animator.SetBool("IsAttack", false);
        collider.offset = new Vector2(-0.1171601f, -0.4635739f);
        collider.size = new Vector2(1.18109f, 1.885352f);
    }

    void Destroy()
    {
        Destroy(this.transform.parent.gameObject);
    }

    void Start()
    {
        animator = GetComponent<Animator>();
        collider = GetComponent<BoxCollider2D>();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (!isAttack && other.tag == "Player") StartCoroutine("Attack");
    }
}
