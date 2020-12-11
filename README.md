# unity-study

### AR 도서 개발을 위한 Unity, Vuforia 기술 검증

#### 시연동영상 : https://youtu.be/F6BA6_Pv9PE

#### 1. Image Target
    - Vuforia cofiguration에서 license와 DB 설정
    - 사용 기능 : AR Camera / Image Target / Asset
    - Image를 카메라로 인식하면 설정한 물체를 띄울 수 있다.

#### 2. AR Animation - Position, Rotation, Scale
    - 사용기능 : Window-Animation-Animation
    - 동화 속 캐릭터의 행동에 응용 가능

#### 3. AR 모델에 애니메이션 삽입, 움직이는 모델 구현 (Advertisement)
    - Image Target에 광고 재생하고 춤추는 곰 Object 만들기
    - 동영상 재생 : 동화책 튜토리얼 / 내용 설명에서 응용 가능 
    - 파티클 시스템 : 동화책 특수 효과에 응용 가능
    - 3D Asset 추가 및 Animation 등록 : 동화 속 캐릭터의 행동에 응용 가능

#### 4. Cardgame
    - 두 카드 위에 각 캐릭터가 상대방을 바라보면 공격하고, 공격을 받아 체력이 0이 되면 죽는 게임
    - 다중 이미지 인식 : 동화책에서 여러개의 Image Target 인식에 응용 가능
    - 3D Text : 동화책 캐릭터 부가 설명, 게임 등에 응용 가능
    - Raycast : 동화책에서 캐릭터 이동 및 대화/ 게임 등에 응용 가능
    - Animation : Animation Controller를 이용하여 상황에 따라 Animation 적용 가능
    - Script : 동화책에서 게임 속 다양한 상황에 따라 Animation 구현에 응용 가능

#### 5. LeanTouch
    - AR 객체 회전, 확대, 이동
    - 터치를 이용하여 객체를 회전, 확대, 이동
    - 캐릭터를 다양한 각도와 크기로 제공하여 몰입감 형성에 응용 가능

#### 6. VirtualButton
    - 가상버튼을 이용하여 객체를 버튼을 눌렀을 때, 누르지 않았을 때 서로 다른 Animation 재생
    - 동화책 속 캐릭터 행동, 미니게임에 응용 가능

#### 7. Markerless
    - Image Target을 미리 지정하지 않고 원하는 위치를 클릭하여 객체를 생성
    - 동화책 확장, 미니게임에 응용 가능

#### 8. Android Build
    - Android App으로 build하여 휴대폰에서 실행
