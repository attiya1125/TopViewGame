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
        playerInputName.characterLimit = 10; // 최대 10자 입력 가능
    }
    public void ValidateInput()
    {
        if (playerInputName.text.Length < textLength) // 2자보다 작게 입력시 입력 필드 지우기
        {
            playerInputName.text = "";
        }
        else // 2~10자 이내일경우 WriteName 실행
        {
            WriteName(); 
        }
    }
    public void WriteName()
    {
        PlayerPrefs.SetString("TextMeshValue", playerInputName.text);
    }
}
