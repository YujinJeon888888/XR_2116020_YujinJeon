using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 @brief 인풋마다 오브젝트의 모양을 달리하는 클래스
 *
 */
public class D04_Mesh_Renderer : MonoBehaviour
{
    MeshFilter ThisMeshFilter;
    public GameObject MySphere, MyCapsule;
    
    // Start is called before the first frame update
    void Start()
    {
        /*컴포넌트 갖고오기*/
        ThisMeshFilter = GetComponent<MeshFilter>();    
    }

    // Update is called once per frame
    void Update()
    {
        /*왼쪽 마우스 버튼: 0*/
        if (Input.GetMouseButtonDown(0))
        {
            //MyCapsule mesh정보로 탈바꿈.
            ThisMeshFilter.mesh = MyCapsule.GetComponent<MeshFilter>().mesh;
        }
        /*오른쪽 마우스 버튼: 1*/
        if (Input.GetMouseButtonDown(1))
        {
            //MySphere mesh정보로 탈바꿈.
            ThisMeshFilter.mesh = MySphere.GetComponent<MeshFilter>().mesh;
        }

        
    }
}
