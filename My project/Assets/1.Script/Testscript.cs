using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testscript : MonoBehaviour
{
    private string name = "김윤규";
    private int age = 26;
    private string MBTI = "INFJ";

    void Start()
    {
        SelfIntroduction();
        Selfintroduction(name, age, MBTI);
    }
    void SelfIntroduction()
    {
        Debug.Log("안녕하세요. 저는 " + name + "입니다.");
        Debug.Log("나이는 " + age + "살입니다.");
        Debug.Log("MBTI는 " + MBTI + "입니다.");
    }

    void Selfintroduction(string name, int age, string MBTI)
    {
        Debug.Log("안녕하세요. 저는 " + name + "입니다.");
        Debug.Log("나이는 " + age + "살입니다.");
        Debug.Log("MBTI는 " + MBTI + "입니다.");
    }
}

