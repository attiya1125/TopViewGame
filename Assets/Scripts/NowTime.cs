using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NowTime : MonoBehaviour
{
    public Text timeTxt;

    // Update is called once per frame
    void Update()
    {
        string currentTime = DateTime.Now.ToString("HH:mm");

        timeTxt.text = currentTime;
    }
}
