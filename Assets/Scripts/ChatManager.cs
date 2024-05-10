using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatManager : MonoBehaviour
{
    public Text ChatText;
    public Text CharacterName;
    public string writerText = "";
    private bool spacePressed = false;
    public float textSpeed = 0.05f;

    IEnumerator NormalChat(string narrator, string narration) // ȭ�ڿ� ���
    {
        int a = 0;
        CharacterName.text = narrator;
        writerText = "";

        for (a= 0; a < narration.Length; a++)
        {
            writerText += narration[a];
            ChatText.text = writerText;
            yield return new WaitForSeconds(textSpeed); // ��簡 �ϳ��� �Է½�Ű�� ȿ��
        }
    }
    IEnumerator WaitForSpacePressed()
    {
        while (!spacePressed)
        {
            yield return null;
        }
        spacePressed = false;
    }

    IEnumerator WriteText()
    {
        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"),"�ȳ��ϼ���"));
        yield return StartCoroutine(WaitForSpacePressed());
        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "�ݰ����ϴ�"));
    }

    public void StartChat()
    {
        StartCoroutine(WriteText());
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePressed = true;
        }
    }

}
