using UnityEngine;

public class LootAtMouse : MonoBehaviour
{
    public TextMesh text;
    private Transform playerTransform;
    private Transform objectTransform;
    private Transform textMashTransform;
    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform; // 캐릭터의 Transform 가져오기
        objectTransform = transform; // 객체의 Transform 가져오기
        textMashTransform = text.transform; // 위에 이름 택스트 위치 가져오기
    }
    private void FixedUpdate()
    {
        // 마우스 위치와 캐릭터 위치를 비교하여 마우스가 캐릭터의 왼쪽에 있는지 확인
        if (Input.mousePosition.x < Camera.main.WorldToScreenPoint(playerTransform.position).x)
        {
            // 캐릭터의 왼쪽에 있는 경우, 객체의 회전 값을 -180도 변경하여 마우스 방향을 바라보도록 설정
            objectTransform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else
        {
            // 캐릭터의 오른쪽에 있는 경우, 객체의 회전 값을 초기화하여 마우스 방향을 바라보도록 설정
            objectTransform.rotation = Quaternion.identity;
        }
        // 위에 이름 텍스트는 안따라오도록 설정
        textMashTransform.rotation = Quaternion.identity;
    }
}