using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button button;
    public ChatManager chatManager;
    public void StartButton()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void StartedChat()
    {
        chatManager = FindObjectOfType<ChatManager>();
        chatManager.StartChat();
    }
    public void ButtonOff()
    {
        button.interactable = false;
    }
    public void ButtonOn()
    {
        button.interactable = true;
    }
}
