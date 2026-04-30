# (C# 코딩) 8주차 과제: Simple Paint
-이름: 하다현 (24018097)

## 개요
- C# 프로그래밍 학습
- 1줄 소개: 두 개의 폴더를 선택하여 파일 목록을 비교하고 관리할 수 있는 Windows Forms 기반 프로그램
- 사용한 플랫폼: C#, .NET Windows Forms, Visual Studio, GitHub, Visual Code
- 사용한 컨트롤: Button, Label, GroupBox, TrackBar, PictureBox
- 사용한 기술과 구현한 기능:
  - Visual Studio를 이용하여 UI 디자인
  - 마우스 드래그를 이용한 그림 그리기 기능 구현
  - 

---

## 실행 화면 (과제1)
- 코드의 실행 스크린샷과 구현 내용 설명

![과제1 실행화면](img/screenshot-1.png)

- 구현한 내용( 위 그림 참조 )
  - 컨트롤들을 위치에 맞게 배치하였다.
  - 사용자가 구분하기 쉽게 GroupBox 3개를 만들어 구분하였다. (도형 선택, 색 선택, 선 두께)
  - 도형 선택 Button에는 Image 속성으로 사진을 추가하였고, ImageAlign 속성을 이용해 Text와 Image 위치를 적절하게 배치하였다.
  - TrackBar 컨트롤을 배치해 그림판의 선 두께를 사용자가 조절할 수 있도록 배치하였다.
  - Button 컨트롤을 이용해 파일 열기와 저장 기능이 가능한 컨트롤을 배치하였다.
  - PictureBox 컨트롤을 이용해 그림판을 배치하였고, BackColor 속성을 이용해 배경색을 흰색으로 만들었다.


    cf) 
    - Label("Simple Paint") -> lblAppName
	- GroupBox 3개 만들기
	  - 1번: btnLine, btnRectangle ,btnCircle Button 3개
	  - 2번: cmbColor ComboBox 
	  - 3번: trbWidth TrackBar
	- Button 2개 만들기 (btnOpenFile, btnSaveFile)
	- PictureBox 1개 (picCanvas) - 그림판

 ---

## 실행 화면 (과제2)
- 코드의 실행 스크린샷과 구현 내용 설명

![과제2 실행화면](img/screenshot-2.png)

- 구현한 내용 (위 그림 참조)
  - FolderBrowserDialog를 사용하여 폴더 선택 기능을 구현하였다.
  - “폴더선택(왼쪽)” 버튼(btnLeftDir) 클릭 시 FolderBrowserDialog를 생성하고 ShowDialog()를 통해 폴더 선택 창을 출력하였다.
  - 사용자가 폴더를 선택하고 확인 버튼을 누르면 SelectedPath 속성을 이용하여 선택한 폴더의 전체 경로를 텍스트박스(txtLeftDir)가져온다.
  - 
  - SelectedPath 사용

---

## 실행 화면 (과제3)
- 코드의 실행 스크린샷과 구현 내용 설명

![과제3 실행화면](img/screenshot-3.png)

- 구현한 내용 (위 그림 참조)

---

## 실행 화면 (과제4)
- 코드의 실행 스크린샷과 구현 내용 설명

![과제4 실행화면](img/screenshot-4.png)

- 구현한 내용 (위 그림 참조)

---

## +) 기능 설명

### 1단계 - 기본 UI 배치 및 기능 구현
  1. UI구성
    - RadioButton과 CheckBox 등을 적절히 배치
    - GroupBox로 적절하게 그룹으로 묶기

  2. GroupBox로 적절하게 그룹으로 묶기
    - RadioButton 한 그룹으로 묶고, CheckBox끼리 한 그룹으로 묶고, ListBox와 총 금액 표시하는 Label 하나로 묶기

  3. 주문하기 버튼과 초기화 버튼 기능 구현
    - ListBox에 주문 내역, Label에 총 금액 표시(총 금액: 0원)
    - 다시 주문할 수 있도록 초기화 버튼 구현

### 2단계 - 에러 표시 개선
  1. 화면 내 오류 표시
    - Label을 이용해 아이디 또는 패스워드가 잘못 입력됐을 때 에러 메시지를 화면에 표시
    - Visible 속성을 이용해 메시지 보이기와 숨기기 기능 구현
  2. UX 개선
    - 사용자에게 즉각적인 피드백 제공
    - 불필요한 MessageBox 사용 최소화

### 3단계 - UX 개선(사용자 편의성 향상)
  1. Enter 키를 누르면 로그인 되도록 포커스 흐름 정리
   - 아이디 입력 -> Enter 누르면 패스워드 입력 창으로 넘어가기
   - 패스워드 입력 -> Enter누르면 로그인 시작하기

  2. 추가 기능
    - 전체 입력 삭제 기능
    - 패스워드를 보여주는 기능(보기/숨기기 가능)
   

### 4단계 - 데이터 관리 및 심화 기능
  1. 아이디와 패스워드 입력 문자 확인
    - 아이디에 넣을 수 없는 글자 체크
    - 비밀번호에 넣을 수 없거나 꼭 들어가야 하는 문자 체크
  2. 로그인 시도 제한
    - 일정 회수가 지나면 정해진 시간 후에 재시도 가능하게
    -  한 단계 더 체크하기
    - 조금 더 복잡하고 

     
---

## 구현 시 어려웠던 점
- 