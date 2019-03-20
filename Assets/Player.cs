using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
    
    public float moveSpeed = 500f;
    public static int points = 0;
    public static int Hpoints;

    float movement = 0f;
    private float incrSpeed = 0.5f;

    void Start() => Hpoints = PlayerPrefs.GetInt("highscore", 0);
    

    void Update() => movement = Input.GetAxisRaw("Horizontal");

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
        moveSpeed += incrSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        endMenu.gameEnd = true;
    }
}
