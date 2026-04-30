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
  - Button 컨트롤을 이용해 파일 입출력을 위한 버튼(btnOpenFile, btnSaveFile)을 배치하여
그림 파일을 열고 저장할 수 있도록 구성하였다.
  - PictureBox(picCanvas)를 이용하여 그림을 그릴 수 있는 캔버스를 구성하였으며, BackColor 속성을 White로 설정하여 배경을 흰색으로 지정하였다.


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
  - 마우스 드래그를 이용하여 그림을 그릴 수 있는 기능을 구현하였다.
  - 사용자가 마우스를 누르고 이동한 후 놓는 동작을 통해 직선, 사각형, 원을 그릴 수 있도록 하였다.
  - 프로그램은 Bitmap 객체를 이용하여 실제 그림 데이터를 저장하고, Graphics 객체를 통해 해당 비트맵 위에 도형을 그리는 방식으로 구현하였다.
  - 마우스 이벤트(MouseDown, MouseMove, MouseUp)를 활용하여 드래그 시작, 진행, 종료를 처리하였다.
   - MouseDown: 드래그 시작 시 시작 좌표를 저장
   - MouseMove: 드래그 중 현재 좌표를 갱신하고, 점선 형태의 미리보기를 화면에 출력
   - MouseUp: 드래그 종료 시 최종 도형을 비트맵에 그려 화면에 고정
  - Paint 이벤트를 활용하여 드래그 중인 도형을 점선 형태로 미리 표시하도록 구현하였다. 이를 통해 사용자가 도형의 크기와 위치를 직관적으로 확인할 수 있다.
  - DrawShape 함수를 별도로 구현하여 직선, 사각형, 원을 공통된 방식으로 그리도록 하였으며, 코드의 재사용성과 가독성을 항상시켰다.
  - GetRectangle 함수를 이용하여 드래그 방향에 관계없이 올바른 사각형 좌표가 계산되도록 하였다.
  
---

## 실행 화면 (과제3)
- 코드의 실행 스크린샷과 구현 내용 설명

![과제3 실행화면](img/screenshot-3.png)

- 구현한 내용 (위 그림 참조)
  - 현재 그림판에 그려진 이미지를 파일로 저장하는 기능을 구현하였다.
  - SaveFileDialog를 사용하여 사용자가 저장할 파일의 경로와 이름을 직접 선택할 수 있도록 구현하였다.
  - 저장 가능한 이미지 형식은 PNG, JPG, BMP 총 3가지로 구성하였다.
  - 사용자가 선택한 파일 확장자에 따라 적절한 ImageFormat을 설정하여 이미지가 저장되도록 구현하였다.
  - Bitmap 객체(canvasBitmap)에 저장된 그림 데이터를 Save 메서드를 이용하여 이미지 파일로 저장하였다.
### 사용된 주요 클래스 및 함수 설명
- SaveFileDialog 클래스
  - Windows Forms에서 파일 저장을 위한 UI 대화상자를 제공하는 클래스이다.
  - ShowDialog() 메서드를 호출하면 사용자에게 저장 창을 표시한다.
- Bitmap 클래스
  - 이미지를 메모리에서 관리하는 객체이다.
  - 현재 그림판에 그려진 모든 그래픽 정보를 저장하고 있는 객체이다.
  - Save() 메서드를 통해 이미지 파일로 저장할 수 있다.
- GraphicsFormat (ImageFormat)
  - 저장할 이미지의 파일 형식을 지정하는 열거형이다.
  - 지원 형식:
    - ImageFormat.Png
    - ImageFormat.Jpeg
    - ImageFormat.Bmp
- Bitmap.Save(string filename, ImageFormat format)
  - Bitmap에 저장된 이미지를 실제 파일로 저장하는 핵심 메서드이다.
  - 첫 번째 인자는 저장 경로 및 파일 이름이다.
  - 두 번째 인자는 저장할 이미지 형식이다.
- EndsWith()
  - 문자열의 끝이 특정 확장자인지 확인하는 함수이다.
  - 파일 확장자(.jpg, .png, .bmp)를 판별하여 저장 형식을 결정하는 데 사용된다.

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