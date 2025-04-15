using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D06_Instantiate_Game_Object : MonoBehaviour
{
    /// <summary>
    /// 복제할 대상
    /// </summary>
    public GameObject Target;
    /// <summary>
    /// 복제할 개수
    /// </summary>
    public int cloneCount = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate_GameObject();
    }

    void Instantiate_GameObject()
    {
        
        for(int i = 0; i < cloneCount; i++)
        {
            //2.5f: 반지름. 2.5반지름인 원 내의 랜덤한 위치 생성
            Vector3 RandomSphere = UnityEngine.Random.insideUnitSphere*2.5f;
            //y고정
            RandomSphere.y = 0f;
            //이 스크립트의 주인의 위치를 기준으로 주위 원형
            Vector3 RandomPos = RandomSphere + transform.position;
            //Random.Value : 0~1f
            float RandomAngle = UnityEngine.Random.value * 360f;
            //y만 랜덤회전값으로
            Quaternion RandomRot = Quaternion.Euler(0, RandomAngle, 0);
            //첫번째인자: 복제 할 대상, 두번쨰인자: 위치 조정, 3번째 인자: 로테이션값
            GameObject Clone = Instantiate(Target, RandomPos, RandomRot);
            //클론활성화
            Clone.SetActive(true);
            //클론의 이름 설정
            Clone.gameObject.name = "Clone-" + string.Format("{0:D4}", i);
            //아이템 컨테이너의 자식으로 만들기
            Clone.transform.SetParent(transform);
        }
    }


}
