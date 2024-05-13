using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatManager : MonoBehaviour
{
    public static ChatManager instance;               // �̱���
    public TopDownMovement topDownMovement;           // ������ �ҷ�����
    public Animator animator;                         // �ִϸ��̼�

    public Text ChatText;                             // ä�ùٿ� �� ����
    public Text CharacterName;                        // �÷��̾� �̸�
    public GameObject ChatBox;                        // ä�� ��, �׸�, �̸� �� �ѹ��� ���� �ִ� �ϴ¿뵵
    public GameObject playerPicture;                  // �÷��̾� �׸�
    public GameObject chatBar;                        // ä�ù�
    public GameObject backGround;                     // ����ε� ��̷� �־����ϴ� ����; �������� ���ɴϴ�


    public string writerText = "";
    public float textSpeed = 0.1f;                    // ä�� �ӵ�

    private bool spacePressed = false;                // �����̽��� bool �뵵

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
    IEnumerator WaitForSpacePressed()  // �����̽��ٸ� �����°� ��ٸ��� ����
    {
        while (!spacePressed)
        {
            yield return null;
        }
        spacePressed = false;
    }

    IEnumerator WriteText()  // ���� �����ϰ� �ٷ� ������ �̾߱�
    {
        playerPicture.SetActive(false);
        yield return StartCoroutine(NormalChat(CharacterName.text = "[System]", "�ν���,,, �ν���,, "));
        yield return StartCoroutine(WaitForSpacePressed());
        playerPicture.SetActive(true);

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "����,, ���� �����,,? "));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "�� �и�,, ������ ������Ʈ ������ �ϰ� �־��µ�,,"));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "������ �������� �� �� ���� ���� �־�,,"));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "�ʹ� ������ �ؼ� ��������,,?"));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "��, �����ʿ� ���� �־�"));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "�ϴ� ���� ���󰡺���"));
        yield return StartCoroutine(WaitForSpacePressed());

        ChatBox.SetActive(false);

        FixedSpeed();
        animator.speed = 1f;
    }
    IEnumerator PeopleText()  // ������ ��ȭ�ϴ� ����
    {
        topDownMovement.takeSpeed = 0;

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "�����,,? �ȳ��ϼ���,,"));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(false);
        yield return StartCoroutine(NormalChat(CharacterName.text = "???", "... "));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(true);
        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "�����,,,??"));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(false);
        yield return StartCoroutine(NormalChat(CharacterName.text = "???", "......"));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(true);
        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "���� ����ΰ�,, "));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(false);
        yield return StartCoroutine(NormalChat(CharacterName.text = "???", "�ʴ� ��� �̰����� ����?"));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(true);
        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "��,,�� �����Ͻ� �� �ƽô±��� "));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "���� �𸣰ھ��. ���� �ߴ� �̰��̴����� "));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "�̰��� ����ΰ���? "));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(false);
        yield return StartCoroutine(NormalChat(CharacterName.text = "???", "..."));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = "???", "�̰��� ���Ű� �ð��� ��.."));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = "???", "�Ͽ����� �̰����� ������ �ؾ��ϴ� ������.."));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(true);
        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "�� �׷��� ����������.. ������ ����� �������? "));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(false);
        yield return StartCoroutine(NormalChat(CharacterName.text = "???", "����"));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(true);
        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "����?"));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(false);
        yield return StartCoroutine(NormalChat(CharacterName.text = "???", "���� ������ ���߰ŵ礻"));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(true);
        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "???????"));
        yield return StartCoroutine(WaitForSpacePressed());

        ChatBox.SetActive(false);
        FixedSpeed();
        backGround.SetActive(true);
    }

    public void StartChat()   // �����̾߱� ���
    {
        animator.speed = 0f;
        ChatBox.SetActive(true);
        StartCoroutine(WriteText());
    }
    public void PeopleChat() // ������ ��ȭ ���� ���
    {
        ChatBox.SetActive(true);
        StartCoroutine (PeopleText());
    }

    private void Update() // �����̽��� �ǽð� ���� �ִ�
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePressed = true;
        }
    }
    private void FixedSpeed() // �÷��̾� �ӵ� ����
    {
        topDownMovement.takeSpeed = 5;
    }
}
