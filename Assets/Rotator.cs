using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotateSpeed = 30f;
    private float incrSpeed = 0.2f;
    public Color color1;
    public Color color2;

    float time;
    float time2;
    float transition;

    int firstColor = 0;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * -rotateSpeed);
        rotateSpeed += incrSpeed * Time.deltaTime;

        if (firstColor == 0)
        {
            color1 = Random.ColorHSV(Random.value + 0.2f, Random.value - 0.2f);
            color2 = Random.ColorHSV(Random.value + 0.2f, Random.value - 0.2f);

            firstColor = 1;
        }

        Camera.main.backgroundColor = Color.Lerp(color2, color1, transition);

        time += Time.deltaTime;
        time2 += Time.deltaTime;
        transition = time2 / 3;

        if (time > 3)
        {
            color2 = color1;
            color1 = Random.ColorHSV(Random.value + 0.2f, Random.value - 0.2f);

            time = 0;
            time2 = 0;
            transition = 0;


        }
    }
}

