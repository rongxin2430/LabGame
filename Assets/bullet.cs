using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D bullets;
    [SerializeField] public Animator firing;

    // Start is called before the first frame update
    void Start()
    {
        bullets.velocity = transform.right * speed;
        firing.SetFloat("Fire", speed);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Block")
        {
            Destroy(gameObject);
            Debug.Log("Hit");
        }
        if(collision.gameObject.tag == "Stone")
        {
            Destroy(gameObject);
            Debug.Log("Hit");
        }
        if(collision.gameObject.tag == "Balloon")
        {
            Destroy(gameObject);
            Debug.Log("Hit");
        }
    }

}
