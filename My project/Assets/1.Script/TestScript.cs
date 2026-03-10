using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    // 1. 내 골드 담길 변수를 선언
    // 2. 포션이 저장될 변수를 선언
    // 3. Start 함수에 조건문을 사용하여 내 골드가 200원 이상이면
    //    200원을 소모하고 포션을 1 증가시키는 식을 작성한다.
    // 4. 나의 남은 골드와 남은 포션의 수량을 출력한다. (Debug.Log() 사용)
    // public, private 안붙이면 기본적으로는 private이지만, public으로 선언하여 인스펙터 창에서 값을 입력할 수 있도록 한다.
    // 인스펙터창으로 볼 수 있게 해주세요 = Public으로 해주세요 는 아예 다른 말. -> so 인스펙터창을 보고싶다? 그러면 인스펙터창으로 볼 수 있게 해달라고 하면 됨.

    [SerializeField] private int myGold;
    [SerializeField] private int myPotion;
    [SerializeField] private int redPotion;
    [SerializeField] private int yellowPotion;
    [SerializeField] private int bluePotion;

    // Start 메서드의 잘못된 선언과 switch문, 변수 선언 위치를 올바르게 수정
    void Start()
    {
        string wish = "노란 포션";

        switch (wish)
        {
            case "빨간 포션":
                myGold -= 200;
                redPotion++;
                break;
            case "노란 포션":
                myGold -= 150;
                yellowPotion++;
                break;
            case "파란 포션":
                myGold -= 100;
                bluePotion++;
                break;
            default:
                Debug.Log("그딴 건 없다. 돌아가 멍청한 놈아");
                break;
        }

        Debug.Log($"남은 골드 : {myGold} / R : {redPotion} / Y : {yellowPotion} / B : {bluePotion}");
    }




}
   

    