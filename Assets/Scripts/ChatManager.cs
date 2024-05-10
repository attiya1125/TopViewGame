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

    IEnumerator NormalChat(string narrator, string narration) // 화자와 대사
    {
        int a = 0;
        CharacterName.text = narrator;
        writerText = "";

        for (a= 0; a < narration.Length; a++)
        {
            writerText += narration[a];
            ChatText.text = writerText;
            yield return new WaitForSeconds(textSpeed); // 대사가 하나씩 입력시키는 효과
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
        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "안녕하세요"));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "반갑습니다"));
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
