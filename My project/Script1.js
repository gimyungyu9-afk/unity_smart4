// JavaScript source cod
// void Start()
//{
   // for(int i = 0; i < 10; i++)
   // {
   //    Gacha();
   // }
    
   // int i = 0;
   // while(true)
   //{
    //    Gacha();
   //     i++;

   //     if (i >= 10)
   //     {
   //         for (int j = 0: j < 1; j++)
   //         {
   //            break;
   //         }
   //     }
   // }
//}

void start()
{
    string[] stringarray = new string[5];
    stringarray [1] = 김윤규 ;
    stringarray [2] = 리오넬 
}


void Gacha()

    int rand = Random.Range(1, 101); // 1이상 101미만의 랜덤한 정수값을 반환

    if (rand <= 5)
    {
        int pickup = Random.Range(0, 2);
        if (pickup == 0)
        {
            Debug.Log("S등급 - 픽업 캐릭터");
        }
        else
        {
            Debug.Log("S등급 - 일반 캐릭터");
        }

    }
    else if (rand <= 20) // <- 이래야 6부터 20이 나와 15%의 확률이다.
    {
        Debug.Log("A등급");

    }
    else if (rand <= 50) // <- 이래야 21부터 50이 나와 30%의 확률이다.
    {
        Debug.Log("B등급");
    }
    else
    {
        Debug.Log("C등급");
    }


// 랜덤한 값이 담길 변수를 선언한다
// 랜덤한 갑의 범위를 설정하고 변수에 담아준다.
// 만약
// 5% 확률로 S등급을 뽑습니다.
// (심화) S등급 가운데 픽업 캐릭터는 50%확률로 등장한다.
// 15% 확률로 A등급을 뽑습니다.
// 30% 확률로 B등급을 뽑습니다.
// 50% 확률로 C등급을 뽑습니다.

