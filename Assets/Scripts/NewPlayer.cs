using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewPlayer : MonoBehaviour
{
    public static NewPlayer instance;
    public Text User;
    public Text uiText;

    public void Awake()
    {
        instance = this;
        // Canvas �ȿ� �ִ� Text UI ��Ҹ� ã��
        uiText = transform.GetChild(2).GetChild(2).GetComponent<Text>();
    }
    // UI�� �ؽ�Ʈ�� �����ϴ� �Լ�
    public void CreateUIText(string message)
    {
        if (uiText != null)
        {
            uiText.text = message;
        }
        else
        {

        }
    }
}
