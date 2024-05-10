using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownContoller contoller;
    private Rigidbody2D movemontRigidbody;
    private Vector2 movementDirection = Vector2.zero; // 이동안하고 있으니 zero

    private void Awake()
    {
        // controller랑 TopDownMovemonet랑 같은 게임 오브젝트 안에 있다라는 가정
        contoller = GetComponent<TopDownContoller>(); // 캐싱
        movemontRigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        contoller.OnMoveEvent += Move;
    }
    private void Move(Vector2 direction) // 일반 프레임 기반
    {
        movementDirection = direction;
    }

    private void FixedUpdate() // 실제로 움직임 처리
    {
        // 물리 업데이트 관련
        // rigidbody의 값을 바꾸니 fixedUpdate
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 0;
        movemontRigidbody.velocity = direction;
    }
}