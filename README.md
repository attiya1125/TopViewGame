## 프로젝트 개요
- 프로젝트 이름 : TopVeiwGame
- 제작자 : Unity_4기 이종민


## 구현 진행도
#### 필수 요구사항 구현
1. 캐릭터 만들기
2. 캐릭터 이동
3. 방 만들기
4. 카메라 따라가기
5. 캐릭터 애니메이션 추가
6. 이름 입력 시스템


#### 추가 요구사항 구현
1. 시간 표시
2. 인게임 이름 바꾸기
3. 참석 인원 UI
4. NPC와 대화


## 주요 스크립트 설명
- GameManager : 플레이어 이름 실시간 변경 / 첫 시작 채팅창 화면 나타내기
- ButtonManager : 각종 버튼 입력으로 인한 모든 처리 기능
- ChatManager : NPC와의 대화 / 시작화면 대화 / 메뉴, 인터페이스 등 각종 채팅 관련 기능 처리
- NewSceneManager : 씬 변경 이후 카메라가 플레이어 따라가는 기능을 유지하게하는 기능 및 씬 변경 이유 편의 기능 추가
- TopDownMovement : 캐릭터가 움직이도록 하는 기능 담당
- CameraManager : 카메라가 플레이어를 따라가도록 하는 기능 담당
- LootAtMouse : 마우스 방향에 따라 플레이어 로테이션 180도 회전

  // 기능을 구현하다 중간에 빠진 기능이 많습니다 허허;

## 구성 시나리오
https://github.com/attiya1125/TopViewGame/blob/main/progress.jpg
