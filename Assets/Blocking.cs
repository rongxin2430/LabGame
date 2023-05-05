using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Blocking : MonoBehaviour
{
    [SerializeField] public int health = 30;
    public Rigidbody2D body;

    public void hit(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Break();

        }
    }
    void Break()
    {
        Destroy(gameObject);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            hit(10);
        }
    }
}
