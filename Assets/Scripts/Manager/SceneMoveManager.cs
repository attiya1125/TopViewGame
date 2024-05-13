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
    public string[] objectTag = { "MoveNextScene", "Player"}; // �Ѿ ���� ������ ������Ʈ��
    private void Awake()
    {
        instance = this;
    }
    public void Start()
    {
        objectMoves = new List<GameObject>(); // ����Ʈ ����

        foreach (string tag in objectTag) // �迭�� �±װ� ���� ��� ������Ʈ�� ����Ʈ�� �ִ´�
        {
            objectMoves.AddRange(GameObject.FindGameObjectsWithTag(tag));
        }

        foreach (GameObject obj in objectMoves) // �� �Ѿ�� �Ⱥμ����� 
        {
            DontDestroyOnLoad(obj);
        }
    }
}
