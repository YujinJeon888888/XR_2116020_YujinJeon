using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

/// <summary>
///  게임 오브젝트를 던지는 스크립트
/// </summary>

public class D06_Put_Controller : MonoBehaviour
{
    /// <summary>
    /// 던질 게임오브젝트 대상
    /// </summary>
    public GameObject TargetObjectToThrow;
    /// <summary>
    /// Player의 위치
    /// </summary>
    /// <remarks>
    /// 플레이어의 카메라 위치에서 오브젝트를 던질 것이기 떄문에, 해당 변수 필요
    /// </remarks>
    public Transform PlayerCamera;
    /// <summary>
    /// 던질 힘
    /// </summary>
    public const float ThrowForce = 400f;
    /// <summary>
    /// 상태 반영을 위해, UI 받아옴
    /// </summary>
    public GameObject UI;
    /// <summary>
    /// 던질 수 있는 영역에 있는가?
    /// </summary>
    private bool bIsInTheArea = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)&& bIsInTheArea)
        {
            int PickCounts = UI.GetComponent<D06_UI_Controller>().GetPickCounts();
            if(PickCounts >0) {
                Throw();
                UI.GetComponent<D06_UI_Controller>().Decrease_PickCounts();
            }
        }
    }

    /// <summary>
    /// TargetObjectToThrow에 할당된 오브젝트를 던지는 함수
    /// </summary>
    void Throw()
    {
        //로컬 기준 앞 위치 (월드기준x)
        Vector3 Pos = PlayerCamera.position + PlayerCamera.forward;

        /*랜덤 회전값 생성*/
        float RandomAngleX = Random.value * 360f;
        float RandomAngleY = Random.value * 360f;
        float RandomAngleZ = Random.value * 360f;
        Quaternion RandomRot = Quaternion.Euler(RandomAngleX, RandomAngleY, RandomAngleZ);  

        //Target오브젝트 생성(세번째인자 : TargetObject 의 Transform의 Rot)
        GameObject Clone = Instantiate(TargetObjectToThrow,Pos,RandomRot);

        //오브젝트 켜 주고
        Clone.SetActive(true);
        //이 오브젝트를 플레이어가 통과하지못하도록
        Clone.GetComponent<Collider>().isTrigger = false;
        Clone.GetComponent<Rigidbody>().useGravity = true;
        //던지기
        Clone.GetComponent<Rigidbody>().AddForce(PlayerCamera.forward* ThrowForce);
        //소멸
        Destroy(Clone, 3);

    }

    /*PutController스크립트의 소유 오브젝트의 트리거를 기준으로, 들어오고 나왔을 때 bIsInTheArea 변수값 업데이트*/
    void OnTriggerEnter(Collider other)
    {
        if(other.name == "FPSController")
        {
            bIsInTheArea = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.name == "FPSController")
        {
            bIsInTheArea = false;
        } 
    }
}
