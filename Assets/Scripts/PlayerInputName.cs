using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInputName : MonoBehaviour
{
    public static InputField playerInputName;
    public int textLength = 2;
    private void Awake()
    {
        playerInputName = GetComponent<InputField>();
    }
    private void Start()
    {
        playerInputName.characterLimit = 10; // �ִ� 10�� �Է� ����
    }
    public void ValidateInput()
    {
        if (playerInputName.text.Length < textLength) // 2�ں��� �۰� �Է½� �Է� �ʵ� �����
        {
            playerInputName.text = "";
        }
        else // 2~10�� �̳��ϰ�� WriteName ����
        {
            WriteName(); 
        }
    }
    public void WriteName()
    {
        PlayerPrefs.SetString("TextMeshValue", playerInputName.text);
    }
}
