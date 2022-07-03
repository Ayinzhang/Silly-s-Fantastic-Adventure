using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#pragma warning disable CS0108

public class Frog : MonoBehaviour
{
    bool isLeft = true;
    bool isReady = false;
    bool isGround = false;
    float epo = 7.0f;
    float jumpWidth = 15.0f;
    float jumpHeight = 65.0f;
    Animator animator;
    Rigidbody2D rigidbody2D;
    public GameObject leftPoint;
    public GameObject rightPoint;

    IEnumerator Jump()
    {
        isReady = true;
        yield return new WaitForSecondsRealtime(Random.Range(0.5f,1.5f));
        if (isLeft && isGround) rigidbody2D.AddForce(new Vector2(-Random.Range(jumpWidth - epo, jumpWidth + epo), Random.Range(jumpHeight - epo, jumpHeight + epo)));
        else if (!isLeft && isGround) rigidbody2D.AddForce(new Vector2(Random.Range(jumpWidth - epo, jumpWidth + epo), Random.Range(jumpHeight - epo, jumpHeight + epo)));
        isReady = false;
    }

    void Destroy()
    {
        Destroy(this.transform.parent.gameObject);
    }

    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Movment
        if (transform.position.x <= leftPoint.transform.position.x) { isLeft = false; transform.localScale = new Vector3(-1, 1, 1); }
        else if (transform.position.x >= rightPoint.transform.position.x) { isLeft = true; transform.localScale = new Vector3(1, 1, 1); }
        if (isGround && !isReady) StartCoroutine("Jump");
        //Animator
        float v = rigidbody2D.velocity.y;
        if (v > 0) { animator.SetBool("IsJumping", true); animator.SetBool("IsFalling", false); animator.SetBool("IsGround", false); }
        else if (v < 0) { animator.SetBool("IsJumping", false); animator.SetBool("IsFalling", true); animator.SetBool("IsGround", false); }
        if (isGround) { animator.SetBool("IsJumping", false); animator.SetBool("IsFalling", false); animator.SetBool("IsGround", true); }
        //Dead
        if (transform.position.y < -10) animator.SetBool("IsDead", true);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Ground")) isGround = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ground")) isGround = false;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground")) transform.rotation = new Quaternion(0, 0, 0, 0);
    }
}
