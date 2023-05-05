using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D bullets;
    public int damage = 10;
    [SerializeField] private AudioSource playSound;
    [SerializeField] public Animator firing;

    // Start is called before the first frame update
    void Start()
    {
        bullets.velocity = transform.right * speed;
        firing.SetFloat("Fire", speed);
    }

    public void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Balloon balloon= hitInfo.GetComponent<Balloon>();
        if (balloon != null)
        {
            balloon.hit(damage);
            Destroy(gameObject);
        }
        Block block = hitInfo.GetComponent<Block>();
        if (block != null)
        {        
            Destroy(gameObject);
        }
        Blocking blocking = hitInfo.GetComponent<Blocking>();
        if (blocking != null)
        {
            
            blocking.hit(damage);
            Destroy(gameObject);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Block")
        {
            playSound.Play();
        }
        if(collision.gameObject.tag == "Stone")
        {
            playSound.Play();
        }
    }

}
