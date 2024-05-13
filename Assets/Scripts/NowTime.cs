using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NowTime : MonoBehaviour
{
    public Text timeTxt;

    void Update() // 현재시간을 불러와서 측정
    {
        string currentTime = DateTime.Now.ToString("HH:mm");

        timeTxt.text = currentTime;
    }
}
