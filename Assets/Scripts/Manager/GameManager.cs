using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public ChatManager chatManager;
    public SetPlayerName setPlayerName;

    public Text userName;

    public void Awake()
    {
    }
    public void Start()
    {
        chatManager.StartChat();
        setPlayerName.SetName();
    }
    private void Update()
    {
        userName.text = PlayerPrefs.GetString("TextMeshValue");
    }
}
