using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreup : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D other)
    {
        audioSource.Play();
        Score.score++;
    }
   
}
