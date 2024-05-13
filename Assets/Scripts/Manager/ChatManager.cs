using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatManager : MonoBehaviour
{
    public static ChatManager instance;               // 싱글톤
    public TopDownMovement topDownMovement;           // 움직임 불러오기
    public Animator animator;                         // 애니메이션

    public Text ChatText;                             // 채팅바에 들어갈 내용
    public Text CharacterName;                        // 플레이어 이름
    public GameObject ChatBox;                        // 채팅 바, 그림, 이름 등 한번에 껏다 켯다 하는용도
    public GameObject playerPicture;                  // 플레이어 그림
    public GameObject chatBar;                        // 채팅바
    public GameObject backGround;                     // 배경인데 재미로 넣었습니다 ㅎㅎ; 마지막에 나옵니다


    public string writerText = "";
    public float textSpeed = 0.1f;                    // 채팅 속도

    private bool spacePressed = false;                // 스페이스바 bool 용도

    private void Awake()
    {
        instance = this;
    }
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
    IEnumerator WaitForSpacePressed()  // 스페이스바를 누르는걸 기다리는 내용
    {
        while (!spacePressed)
        {
            yield return null;
        }
        spacePressed = false;
    }

    IEnumerator WriteText()  // 게임 시작하고 바로 나오는 이야기
    {
        playerPicture.SetActive(false);
        yield return StartCoroutine(NormalChat(CharacterName.text = "[System]", "부스럭,,, 부스럭,, "));
        yield return StartCoroutine(WaitForSpacePressed());
        playerPicture.SetActive(true);

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "으윽,, 여긴 어디지,,? "));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "나 분명,, 집에서 프로젝트 마감을 하고 있었는데,,"));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "정신을 차려보니 알 수 없는 곳에 있어,,"));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "너무 열심히 해서 쓰려졌나,,?"));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "앗, 오른쪽에 길이 있어"));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "일단 길을 따라가보자"));
        yield return StartCoroutine(WaitForSpacePressed());

        ChatBox.SetActive(false);

        FixedSpeed();
        animator.speed = 1f;
    }
    IEnumerator PeopleText()  // 집들어가서 대화하는 내용
    {
        topDownMovement.takeSpeed = 0;

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "저기요,,? 안녕하세요,,"));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(false);
        yield return StartCoroutine(NormalChat(CharacterName.text = "???", "... "));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(true);
        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "저기요,,,??"));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(false);
        yield return StartCoroutine(NormalChat(CharacterName.text = "???", "......"));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(true);
        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "뭐지 벙어리인가,, "));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(false);
        yield return StartCoroutine(NormalChat(CharacterName.text = "???", "너는 어떻게 이곳까지 왔지?"));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(true);
        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "ㅁ,,아 말씀하실 줄 아시는군요 "));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "저도 모르겠어요. 눈을 뜨니 이곳이더군요 "));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "이곳은 어디인가요? "));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(false);
        yield return StartCoroutine(NormalChat(CharacterName.text = "???", "..."));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = "???", "이곳은 정신과 시간의 방.."));
        yield return StartCoroutine(WaitForSpacePressed());

        yield return StartCoroutine(NormalChat(CharacterName.text = "???", "하염없이 이곳에서 생각을 해야하는 방이지.."));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(true);
        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "전 그러고 싶지않은데.. 나가는 방법은 없을까요? "));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(false);
        yield return StartCoroutine(NormalChat(CharacterName.text = "???", "없다"));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(true);
        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "왜죠?"));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(false);
        yield return StartCoroutine(NormalChat(CharacterName.text = "???", "아직 구현을 못했거든ㅋ"));
        yield return StartCoroutine(WaitForSpacePressed());

        playerPicture.SetActive(true);
        yield return StartCoroutine(NormalChat(CharacterName.text = PlayerPrefs.GetString("TextMeshValue"), "???????"));
        yield return StartCoroutine(WaitForSpacePressed());

        ChatBox.SetActive(false);
        FixedSpeed();
        backGround.SetActive(true);
    }

    public void StartChat()   // 시작이야기 출력
    {
        animator.speed = 0f;
        ChatBox.SetActive(true);
        StartCoroutine(WriteText());
    }
    public void PeopleChat() // 집들어가서 대화 내용 출력
    {
        ChatBox.SetActive(true);
        StartCoroutine (PeopleText());
    }

    private void Update() // 스페이스로 실시간 껏다 켯다
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePressed = true;
        }
    }
    private void FixedSpeed() // 플레이어 속도 복구
    {
        topDownMovement.takeSpeed = 5;
    }
}
