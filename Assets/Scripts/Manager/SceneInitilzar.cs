using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneInitilzar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject obj in SceneMoveManager.objectMove)
        {
            obj.transform.position = Vector3.zero;
        }
        SceneMoveManager.objectMove = null;
    }
}
