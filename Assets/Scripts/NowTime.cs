using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NowTime : MonoBehaviour
{
    public Text timeTxt;

    void Update() // ����ð��� �ҷ��ͼ� ����
    {
        string currentTime = DateTime.Now.ToString("HH:mm");

        timeTxt.text = currentTime;
    }
}
