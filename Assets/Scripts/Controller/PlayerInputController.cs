using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownContoller
{
    private Camera camera;

    private void Awake()
    {
        camera = Camera.main; // mainCamera 태그 붙어있는 카메라 가져오기
    }
    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }
    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(newAim); // 카메라의 범위 월드 좌표
        newAim = (worldPos - (Vector2)transform.position).normalized; 

        CallLookEvent(newAim);
    }
}
