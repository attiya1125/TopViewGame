using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownContoller contoller;
    private Rigidbody2D movemontRigidbody;
    private Vector2 movementDirection = Vector2.zero; // �̵����ϰ� ������ zero

    private void Awake()
    {
        // controller�� TopDownMovemonet�� ���� ���� ������Ʈ �ȿ� �ִٶ�� ����
        contoller = GetComponent<TopDownContoller>(); // ĳ��
        movemontRigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        contoller.OnMoveEvent += Move;
    }
    private void Move(Vector2 direction) // �Ϲ� ������ ���
    {
        movementDirection = direction;
    }

    private void FixedUpdate() // ������ ������ ó��
    {
        // ���� ������Ʈ ����
        // rigidbody�� ���� �ٲٴ� fixedUpdate
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 0;
        movemontRigidbody.velocity = direction;
    }
}