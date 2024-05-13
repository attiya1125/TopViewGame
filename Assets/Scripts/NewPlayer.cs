using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewPlayer : MonoBehaviour
{
    public static NewPlayer instance;
    public Text user1;

    public void Awake()
    {
        instance = this;
        // Canvas 안에 있는 Text UI 요소를 찾음
        user1 = transform.GetChild(2).GetChild(2).GetComponent<Text>();
    }
    // UI에 텍스트를 생성하는 함수
    public void CreateUIText(string message)
    {
        if (user1 != null)
        {
            user1.text = message;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
