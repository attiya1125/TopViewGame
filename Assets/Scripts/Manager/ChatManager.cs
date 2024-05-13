using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatManager : MonoBehaviour
{
    public static ChatManager instance;
    public TopDownMovement topDownMovement;
    public Animator animator;

    public Text ChatText;
    public Text CharacterName;
    public GameObject ChatBox;
    public GameObject playerPicture;
    public GameObject chatBar;

    public string writerText = "";
    public float textSpeed = 0.05f;

    private bool spacePressed = false;

    private void Awake()
    {
        instance = this;
    }
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
        animator.speed = 1f;
    }
    IEnumerator PeopleText()
    {
        topDownMovement.takeSpeed = 0;
        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "asdasdas"));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "asdsadad"));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "asdasdsa"));
        yield return StartCoroutine(WaitForSpacePressed());

        ChatBox.SetActive(false);

        FixedSpeed();
    }

    public void StartChat()
    {
        animator.speed = 0f;
        ChatBox.SetActive(true);
        StartCoroutine(WriteText());
    }
    public void PeopleChat()
    {
        ChatBox.SetActive(true);
        StartCoroutine (PeopleText());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePressed = true;
        }
    }
    private void FixedSpeed()
    {
        topDownMovement.takeSpeed = 5;
    }
}
