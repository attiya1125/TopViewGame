using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneInitilzar : MonoBehaviour
{
    public GameObject a;
    void Start()
    {

        foreach (GameObject obj in SceneMoveManager.objectMoves)
        {
            obj.transform.position = Vector3.zero;
        }
        SceneMoveManager.objectMoves = null;

    }
}
