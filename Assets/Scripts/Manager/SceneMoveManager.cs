using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SceneMoveManager : MonoBehaviour
{
    public static GameObject[] objectMove;
    public string[] objectTag = { "MoveNextScene", "Player", "MainCamera" };
    public void Start()
    {
        List<GameObject> objectsToMove = new List<GameObject>();

        foreach (string tag in objectTag)
        {
            Debug.Log(tag);
            GameObject[] objectWithTags = GameObject.FindGameObjectsWithTag(tag);
            objectsToMove.AddRange(objectWithTags);
        }

        objectMove = objectsToMove.ToArray();

        foreach (GameObject obj in objectMove)
        {
            DontDestroyOnLoad(obj);
        }
    }
}
