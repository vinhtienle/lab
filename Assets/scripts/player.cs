using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject panel;
    
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    float movePrefix = 6;
    // Update is called once per frame

    public void Jum()
    {
        rb.AddForce(Vector2.up * 6, ForceMode2D.Impulse);
     
        
    }
    public void moveLeft()
    {
        spriteRenderer.flipX = true;
        rb.AddForce(Vector2.left * movePrefix, ForceMode2D.Impulse);
    }

    public void moveRight()
    {
        spriteRenderer.flipX = false;
        rb.AddForce(Vector2.right * movePrefix, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ( collision.gameObject.tag == "die")
        {
            Time.timeScale = 0;
            panel.SetActive(true);
        }
    }
    void Update()
    {
        
    }
}
