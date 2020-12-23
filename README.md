# BSG
모의주식투자 리그게임



 2014년도에 외국의 Stock Fantasy League 프로젝트를 수행한 팀1의 주식 리그와 같이 일종의 ‘모의 주식 투자 리그 게임’을 제작
 
 먼저 팀1의 프로젝트를 해석하고 참고하여 이를 바탕으로 사용하지만, 팀1과는 다르게 웹 프로그래밍을 사용하지 않고 C#을 사용하여 윈도우 애플리케이션으로 제작.

 사용하는 플랫폼이 달라졌기 때문에 기본적인 베이스는 Stock Fantasy League와 비슷하지만 GUI를 포함한 많은 부분에서 팀1과는 다름. 
 
 크게는 웹 프로그램에서 서버 – 클라이언트 프로그램으로 달라질 것이고, 세부적으로는 로그인 방법, 리그 진행 등 여러 부분에서 변화가 있음. 
 
 프로젝트의 중심이 되는 주식 API는 Stock Fantasy League와 동일하게 야후 API를 사용할 것이지만, 야후 API가 웹 프로그램에는 정리된 주식 정보를 제공하는 반면에 
 
 윈도우 애플리케이션에 제공할 때는 한 번에 한 개의 주식에 대한 정보를 Exel 파일로 제공하기 때문에 이를 제대로 사용하기 위한 연구가 필요.
 
 
 ver 0.3
(1) 회원가입 부분 추가

(2) 직렬화, 역직렬화 추가

ver 0.4
(1) Server 접속 유연성 향상

ver 0.5
(1) LeagueView.cs
처음에 view1, view2 전송, return.bin, return2.bin 생성

(2) Serial.cs
Deserial 매개변수로 파일 이름 주기로 변경

(3) ClientSocket.cs
새로운 메서드 추가
FileTransfer() >> 첫 번째 매개변수 : stock, view1, view2 ..... / 두 번째 매개변수 : 파일네임 / return : 없음

ver 0.6
(1) Main.cs
처음에 stock 전송, return.bin 파일 역직렬화
리스트뷰 추가.(캡처 사진 참고)

ver 0.7
(1) Timer가 다른 대화상자가 실행중일 때도 정상적으로 작동하는지 확인 완료.

(2) LeagueForm.cs
MainForm의 주식 ListView 아이템을 불러와서 LeagueForm의 ListView에 추가하는 기능 생성.

ver 0.9
(1) LeagueForm.cs 주식 주문/판매

(2) LeagueView.cs 가입목록, 리그목록 불러오기

ver 1.0
(1) LeagueView.cs
가입목록, 리그목록 불러오기 완료(string 파일)

(2) MainForm.cs
주식정보 불러오기 완료(string 파일)

(3) CreateLeage.cs
리그 생성 완료(string 파일)

ver 1.1
(1) LeagueView.cs
리그 참가 완료

ver 1.2
(1) CreateLeague.cs
이미 리그를 소유한 사람이 새로운 리그를 더 이상 생성할 수 없도록 하는 기능 추가.

(3) LeagueForm.cs
주식 구매 판매 알고리즘 완료

(4) 주식, 리그에 대한 새로운 프로토콜 추가
