using UnityEngine;

public class CharacterAnimationController : AnimationController
{
    private static readonly int isWalking = Animator.StringToHash("isWalking");
    private static readonly int isHit = Animator.StringToHash("isHit");
    private static readonly int Attack = Animator.StringToHash("attack");

    private readonly float magnituteThreshold = 0.5f; // 0.5 이상을 움직여야 움직임 처리된다
    protected override void Awake()
    {
        base.Awake();
    }
    private void Start()
    {
        contoller.OnMoveEvent += Move;
    }

    private void Move(Vector2 vector)
    {
        animator.SetBool(isWalking, vector.magnitude > magnituteThreshold);
    }

    private void InvincibilityEnd() // 무적
    {
        animator.SetBool(isHit, false);
    }
}