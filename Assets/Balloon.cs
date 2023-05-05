using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Balloon : MonoBehaviour
{
    Rigidbody2D body;
    public float speed = 2;
    private Vector2 direction;
    public int health = 1;
    public float scale = 1.0f;
    public int score;
    public TextMeshProUGUI scoreUI;
    public int MaxPointGain = 10;
    [SerializeField] private AudioSource poping;

    // Start is called before the first frame update
    void Start()
    {
        score = PersistentData.Instance.GetScore();
        InvokeRepeating("Expand", 2.0f, 2.0f);
        InvokeRepeating("PointLose", 2.0f, 2.0f);
        GameObject.Find("Score").GetComponent<TextMeshProUGUI>().SetText(score.ToString());

    }
    public void Expand()
    {
        if (scale >= 1.8f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        scale += 0.2f;
        transform.localScale = new Vector2(scale, scale);

    }
    public void hit(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            poping.Play();
            Pop();
        }
    }
    void Pop()
    {
        score += MaxPointGain;
        PersistentData.Instance.SetScore(score);
        GameObject.Find("Score").GetComponent<TextMeshProUGUI>().SetText(score.ToString());
        Destroy(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        if (transform.position.y >= 2.5)
        {
            direction = Vector2.down;
        }
        else if (transform.position.y <= -1.5)
        {
            direction = Vector2.up;
        }
    }
    public void PointLose()
    {
        MaxPointGain -= 1;
    }
}
