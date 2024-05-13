using System;
using UnityEngine;

public class TopDownAimController : MonoBehaviour
{
    [SerializeField] private GameObject PlayerObject;

    private TopDownContoller contoller;

    private void Awake()
    {
        contoller = GetComponent<TopDownContoller>();
    }
    private void OnAim(Vector2 direction)
    {
        RotateArm(direction);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotz = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
    }

}
