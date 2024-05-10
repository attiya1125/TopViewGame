using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatManager : MonoBehaviour
{
    public ButtonManager buttonManager;

    public Text ChatText;
    public Text CharacterName;
    public string writerText = "";
    private bool spacePressed = false;
    public float textSpeed = 0.05f;
    public GameObject ChatBox;

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
        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "�ȳ��ϼ���"));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "�ݰ����ϴ�"));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "zzzxc"));
        yield return StartCoroutine(WaitForSpacePressed());
        ChatBox.SetActive(false);
        FixedSpeed();
    }

    public void StartChat()
    {
        ChatBox.SetActive(true);
        StartCoroutine(WriteText());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePressed = true;
        }
    }
    public void FixedSpeed()
    {
        TopDownMovement topDownMovement = GetComponent<TopDownMovement>();
        topDownMovement.takeSpeed = 5;
    }
}
