using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSceneManager : MonoBehaviour
{
    public MainCameraController cameraController;
    public GameObject peopleBtn;
    public void ClickBtn()
    {
        ButtonManager.instance.PeopleChatStart();
        peopleBtn.SetActive(false);
    }
    public void Start()
    {
        cameraController.player = GameManager.instance.Player.transform;
    }
}
