# 응용소프트웨어실습 Team - 도구상자 

# 내가 그린 기린구름그림
------------------------------------------
## 1. 소프트웨어 소개
    C#과 소켓 통신을 이용한 캐치마인드 리뉴얼 게임입니다.
    사용자는 로그인 후 대기방 중 원하는 곳에 입장합니다.
    2명 이상이 모이면 게임을 시작할 수 있으며, 한명이 그림을 그리면 나머지 사람들은 정답을 맞춥니다.
    정답을 맞출 시 남은 시간만큼 점수를 획득하게 되며,
    라운드가 끝났을 때 점수 순서대로 등수가 결정됩니다.

![image](https://github.com/Suhun0331/DrawingQuiz/assets/104614675/ca45f1d2-39e0-4401-ab36-c6a0233c1d3b)

![image](https://github.com/Suhun0331/DrawingQuiz/assets/104614675/47e62d18-f422-4f18-8721-d97b6a2bdbea)

    Host를 클릭하고 인원수를 설정하면 Host의 IP와 Port 번호로 서버소켓이 열리며 방이 생성됩니다.

![image](https://github.com/Suhun0331/DrawingQuiz/assets/104614675/2db1fa73-84b9-41d4-892a-d460da0b895b)

    Guest는 들어가고 싶은 방의 Host의 IP와 Port번호를 입력하여 해당 방에 입장하게 됩니다.

![image](https://github.com/Suhun0331/DrawingQuiz/assets/104614675/6d3c7f64-2439-4c6d-b02a-c4f3e81b64b7)

    방에 입장하기 전에, 닉네임과 자신이 사용할 프로필을 직접 그려서 설정할 수 있습니다.

![image](https://github.com/Suhun0331/DrawingQuiz/assets/104614675/37e68140-a314-4b4c-ae6e-30e72361d2b7)

    대기방에 입장한 화면이며, 한 방에는 총 4인까지 입장 가능합니다.
    가장 처음 방을 만든 방장이 Start 버튼을 누르면 게임이 시작되며, 그림 그리기가 시작됩니다.

![image](https://github.com/Suhun0331/DrawingQuiz/assets/104614675/fff989f6-a0af-4897-ae45-62b0ec5faabe)

    게임이 종료되면 획득한 점수를 합산하여 등수를 보여줍니다.

