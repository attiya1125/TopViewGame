using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public SetPlayerName SetPlayerName;
    public string name;
    public void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void TakeName(string playerName)
    {
        name = playerName;
        SetPlayerName = GetComponent<SetPlayerName>();
    }
}
