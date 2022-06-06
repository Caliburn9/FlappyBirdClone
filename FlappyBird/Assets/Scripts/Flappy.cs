using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    public GameManager gameManager;
    Rigidbody2D rb;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, jumpForce);
    }

    void BoostonYaxis()
    {
        rb.velocity = new Vector2(0, jumpForce);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Death")
        {
            Debug.Log("Dead");
            gameManager.gameOver();
        }

        if (collision.tag == "Win")
        {
            Debug.Log("Win");
            gameManager.score++;
            Debug.Log("Score = " + gameManager.score.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(Vector2.up * jumpForce * Time.deltaTime);
            BoostonYaxis();
        }
    }
}
