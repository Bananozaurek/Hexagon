using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Highscore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI tmp = this.gameObject.GetComponent<TextMeshProUGUI>();
        tmp.text = "Highscore: " + Player.Hpoints;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("highscore") < Player.points)
        {
            Player.Hpoints = Player.points;
            TextMeshProUGUI tmp = this.gameObject.GetComponent<TextMeshProUGUI>();
            tmp.text = "Highscore: " + Player.Hpoints;
            PlayerPrefs.SetInt("highscore", Player.Hpoints);
            PlayerPrefs.Save();
        }
    }
}
