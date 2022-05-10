using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    public float speed = 1f;
    private Rigidbody2D rig;

    public GameObject gameOver;
    public GameObject score;
    public AudioSource audioAsa;
    public AudioSource audioBatida;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rig.velocity = Vector2.up * speed;
            audioAsa.Play();
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        audioBatida.Play();
        gameOver.SetActive(true);
        score.SetActive(false);
        Time.timeScale = 0;
    }
}
