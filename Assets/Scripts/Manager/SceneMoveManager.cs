using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class SceneMoveManager : MonoBehaviour
{
    public static SceneMoveManager instance;
    public static List<GameObject> objectMoves;
    public string[] objectTag = { "MoveNextScene", "Player"}; // 넘어갈 씬에 보존할 오브젝트들
    private void Awake()
    {
        instance = this;
    }
    public void Start()
    {
        objectMoves = new List<GameObject>(); // 리스트 선언

        foreach (string tag in objectTag) // 배열안 태그가 적힌 모든 오브젝트를 리스트에 넣는다
        {
            objectMoves.AddRange(GameObject.FindGameObjectsWithTag(tag));
        }

        foreach (GameObject obj in objectMoves) // 씬 넘어가도 안부서지게 
        {
            DontDestroyOnLoad(obj);
        }
    }
}
