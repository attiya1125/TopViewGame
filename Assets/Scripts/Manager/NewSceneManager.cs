using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSceneManager : MonoBehaviour
{
    public MainCameraController cameraController;
    public GameObject peopleBtn;
    public void ClickBtn()  // 버튼 메니저에 있는 메서드로 가는 구문
    {
        ButtonManager.instance.PeopleChatStart();
        peopleBtn.SetActive(false);
    }
    public void Start()
    {
        cameraController.player = GameManager.instance.Player.transform; // 새로 바뀐 씬에서 카메라가 플레이어 오브젝트를 따라가도록 구현
        NewPlayer.instance.CreateUIText("Unknown"); // 집안 사람 이름
    }
}
