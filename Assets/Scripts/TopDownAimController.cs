using System;
using UnityEngine;

public class TopDownAimController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer armRenderer;
    [SerializeField] private Transform aimPivot;
    [SerializeField] private SpriteRenderer PlayerRenderer;

    private TopDownContoller contoller;

    private void Awake()
    {
        contoller = GetComponent<TopDownContoller>();
    }
    private void Start()
    {
        contoller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        RotateArm(direction);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotz = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        PlayerRenderer.flipX = Mathf.Abs(rotz) > 90f;

        aimPivot.rotation = Quaternion.Euler(0f, 0f, rotz);
    }

}