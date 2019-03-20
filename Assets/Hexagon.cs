using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    float alpha = 1.0f;

    private LineRenderer lr;
    public Rigidbody2D rb;

    public float shrinkSpeed = 5f;
    private float incrSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 20f;
        lr = GetComponent<LineRenderer>();

        Gradient gradient = new Gradient();
        gradient.SetKeys(
            new GradientColorKey[] { new GradientColorKey(Random.ColorHSV(Random.value + 0.1f, Random.value - 0.1f), 0.0f), new GradientColorKey(Random.ColorHSV(Random.value + 0.1f, Random.value - 0.1f), 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 1.0f) }
        );
        lr.colorGradient = gradient;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        shrinkSpeed += incrSpeed * Time.deltaTime;

        if (transform.localScale.x <= .05f)
        {
            Player.points = Player.points + 1;
            Destroy(gameObject);
        }

    }
}
