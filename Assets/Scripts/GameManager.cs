using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public ChatManager chatManager;
    public void Start()
    {
        chatManager.StartChat();
    }
}
