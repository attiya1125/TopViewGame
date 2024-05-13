using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public static ButtonManager instance;
    public TopDownMovement topDownMovement;
    public ChatManager chatManager;

    public GameObject sideBar;
    public GameObject meruBar;
    public GameObject changeNameBtn;
    public GameObject x_Btn;
    public GameObject hambugar;
    public GameObject newNamePanel;

    public bool isOn = true;

    private void Awake()
    {
        instance = this;
    }

    public void StartButton() // 메인씬으로 가는버튼
    {
        SceneManager.LoadScene("MainScene");
    }

    public void CloseTabBtn() // 텝 닫는 버튼
    {
        sideBar.SetActive(false);
        meruBar.SetActive(false);
        changeNameBtn.SetActive(false);
        x_Btn.SetActive(false);

        hambugar.SetActive(true);
    }
    public void OnpenTabBtn()  // 텝 여는 버튼
    {
        sideBar.SetActive(true);
        meruBar.SetActive(true);
        changeNameBtn.SetActive(true);
        x_Btn.SetActive(true);

        hambugar.SetActive(false);
    }

    public void NewName()     // 새 이름 만들때 판넬 나오게 하는 버튼
    {
        topDownMovement.takeSpeed = 0;
        newNamePanel.SetActive(true);
    }

    public void SideBar() // 사이드바 출력
    {
        if (isOn)
        {
            sideBar.SetActive(false);
        }
        else
        {
            sideBar.SetActive (true);
        }
        isOn = !isOn;
    }
    public void InHouse()  // 집 들어가는 씬
    {
        SceneManager.LoadScene("HouseScene");
    }

    public void PeopleChatStart()  // 집안 사람이랑 대화시작
    {
        ChatManager.instance.PeopleChat();
    }
}
