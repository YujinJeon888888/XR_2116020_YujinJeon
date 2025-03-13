using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 @brief ��ǲ���� ������Ʈ�� ����� �޸��ϴ� Ŭ����
 *
 */
public class D04_Mesh_Renderer : MonoBehaviour
{
    MeshFilter ThisMeshFilter;
    public GameObject MySphere, MyCapsule;
    
    // Start is called before the first frame update
    void Start()
    {
        /*������Ʈ �������*/
        ThisMeshFilter = GetComponent<MeshFilter>();    
    }

    // Update is called once per frame
    void Update()
    {
        /*���� ���콺 ��ư: 0*/
        if (Input.GetMouseButtonDown(0))
        {
            //MyCapsule mesh������ Ż�ٲ�.
            ThisMeshFilter.mesh = MyCapsule.GetComponent<MeshFilter>().mesh;
        }
        /*������ ���콺 ��ư: 1*/
        if (Input.GetMouseButtonDown(1))
        {
            //MySphere mesh������ Ż�ٲ�.
            ThisMeshFilter.mesh = MySphere.GetComponent<MeshFilter>().mesh;
        }

        
    }
}
