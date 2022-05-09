using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameController controller;
    public AudioSource audioScore;

    void Start()
    {
        controller = FindObjectOfType<GameController>();
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        audioScore.Play();
        controller.score++;
        controller.scoreText.text = controller.score.ToString();
    }
}
