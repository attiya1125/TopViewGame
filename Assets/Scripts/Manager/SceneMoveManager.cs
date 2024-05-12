using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SceneInitializer : MonoBehaviour
{
    public static GameObject[] objectMove;
    public string objectTag = "MoveNextScene";
    public void Start()
    {
        objectMove = GameObject.FindGameObjectsWithTag("MoveNextScene");
        objectMove = GameObject.FindGameObjectsWithTag("Player");
        objectMove = GameObject.FindGameObjectsWithTag("MainCamera");
    }
}
