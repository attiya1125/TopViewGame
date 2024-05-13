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
        // Canvas �ȿ� �ִ� Text UI ��Ҹ� ã��
        user1 = transform.GetChild(2).GetChild(2).GetComponent<Text>();
    }
    // UI�� �ؽ�Ʈ�� �����ϴ� �Լ�
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
