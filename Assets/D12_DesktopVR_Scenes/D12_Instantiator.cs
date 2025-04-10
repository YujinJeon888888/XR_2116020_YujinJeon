using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D12_Instantiator : MonoBehaviour
{
    public GameObject TargetObject;
    const int cloneCount = 10;

    // Start is called before the first frame update
    void Start()
    {
        InstantiateHearts();
    }



    void InstantiateHearts()
    {
        for(int i = 0; i < cloneCount; i++) {
            //Random.value : 0~1사이 랜덤숫자 (소숫점)
            //Random.insideUnitSphere: 기준점 중심으로 Sphere 영역 만들고 그 내 랜덤좌표를 만듦.
            Vector3 randomSphere = Random.insideUnitSphere*5;
            //y만 고정
            randomSphere.y = 0.5f;

            //+ transform.position: 해당 스크립트의 주인을 중심으로 원형을 그린 뒤 원형 안 랜덤위치
            Vector3 randomPos = randomSphere + transform.position;

            //회전값 구하기 위해: 360도 * 분수
            float randomAngle = Random.value * 360f;
            //유니티의 회전값자료형: Quaternion //Quaternion는 매개변수를 4개 넣어줘야한다. // 3개의 값을 4개값으로 바꿔주는 함수: Euler
            Quaternion randomRot = Quaternion.Euler(0, randomAngle, 0);

            //첫번째인자: 대상오브젝트, 두번째인자: 위치
            GameObject clone = Instantiate(TargetObject, randomPos, randomRot);
            //특정 게임오브젝트를 부모로 함. (SetParant : 계층관리. 계층관리는 transform이 담당하므로, 여기에 메서드가있다. )
            //계층화한이유: 부모만 비활성화해도 하위가 모두 비활성화되므로.
            clone.transform.SetParent(transform);


        }
    }
}
