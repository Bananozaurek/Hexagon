using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pointCounter : MonoBehaviour { 

    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI tmp = this.gameObject.GetComponent<TextMeshProUGUI>();
        tmp.text = "        "+Player.points;
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI tmp = this.gameObject.GetComponent<TextMeshProUGUI>();
        tmp.text = "        " + Player.points;
    }
}
