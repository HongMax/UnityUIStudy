using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Delegate(대리자)는 함수를 변수처럼 전달
/// 대리자는 함수에 대한 참조를 캡슐화하는 객체
/// 호환되는 시그니처(함수 반환타입, 함수 매개변수)를 가진 모든 함수를 참조할 수 있으며,
/// 콜백 함수 구현, 이벤트 처리 등의 고급 프로그래밍 기법을 쉽게 적용할 수 있게 함.
/// 매니저같은 역할임. 최상단에 선언
/// 
/// 특징
/// 1. 메소드 참조: 대리자는 하나 이상의 메소드를 참조 가능
/// </summary>
public class DelegateTest : MonoBehaviour
{
    public delegate void TestDelegate();
    public delegate int TestDelegateInt(int a, int b);
    public TestDelegate testDelegate;
    public TestDelegateInt testDelegateInt;

    // Start is called before the first frame update
    void Start()
    {
        testDelegate = PrintText;
        testDelegate += PrintText2; //추가
        testDelegateInt = PrintTextInt;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            testDelegate();
            testDelegate -= PrintText2; //삭제
            testDelegateInt(1,2);
            PrintTextAll();
            PrintTextInt(1,2);
        }
    }
    
    private void PrintTextAll(){
        PrintText();
        PrintText2();
    }
    public void PrintText(){
        Debug.Log($"Delegate 호출: ");
    }
    private void PrintText2(){
        Debug.Log($"Delegate 호출2: ");
    }
    private int PrintTextInt(int a, int b){
        Debug.Log($"Delegate 호출: {a} / {b}");
        return 0;
    }
}
