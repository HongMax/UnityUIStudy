using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
/// <summary>
/// 이벤트는 객체나 클래스가 특정 상황을 다른 객체에게 알리는 기능을 제공.
/// 
/// </summary>
public class EventTest : MonoBehaviour
{
    [SerializeField] private static string name1 ="A";
    [SerializeField] private static string description1="B";
    public class Test{
        public string name;
        public string description;
        public Test(){
            name = name1;
            description = description1;
        }
    }
    public UnityEvent<Test> OnUnityEvent;
    public UnityEvent OnUnityEvent2;
    public DelegateTest delegateTest;
    /*
    public class Event : EventArgs{
        public string Message;
        public Event(string message){Message = message;}
    }
    public class Publisher{
        public event EventHandler<Event> OnEvent;
        public void OnCustomEvent(Event e){

        }
    }
    */
    // Start is called before the first frame update
    void Start()
    {
        delegateTest = GetComponent<DelegateTest>();
        OnUnityEvent.AddListener(OnEvent);
        //OnUnityEvent.AddListener(delegateTest.PrintText);

        //람다식
        OnUnityEvent2.AddListener(() => {
            Debug.Log("람다식 호출");
        });
    }

    private void OnEvent(Test test){
        Debug.Log($"OnEvent: {test.name} / {test.description}");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K)){

            OnUnityEvent.Invoke(new Test());
        }
    }
}
