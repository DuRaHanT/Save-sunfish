using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Touch : MonoBehaviour
{
    Rigidbody2D rb;
    public float JumpPower;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audioSource.Play();
            rb.velocity = Vector2.up * JumpPower;
            if (Score.score == 10)
            {
                JumpPower = JumpPower + 0.2f;
            }

            else if (Score.score == 30)
            {
                JumpPower = JumpPower + 0.2f;
            }
            else if (Score.score == 70)
            {
                JumpPower = JumpPower + 0.2f;
            }

            else if (Score.score == 125)
            {
                JumpPower = JumpPower + 0.2f;
            }

            else if (Score.score == 180)
            {
                JumpPower = JumpPower + 0.2f;
            }

            else if (Score.score == 300)
            {
                JumpPower = JumpPower + 0.2f;
            }
        }

        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(Score.score > Score.bestScore)
        {
            Score.bestScore = Score.score;
        }
        SceneManager.LoadScene("GameOver");
    }
}
