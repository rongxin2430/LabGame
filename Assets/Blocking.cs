using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Blocking : MonoBehaviour
{
    public int health = 30;
    Rigidbody2D body;
    // Start is called before the first frame update
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
}
