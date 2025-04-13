using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//슬라이더 컴포넌트 활용을 위해 네임스페이스 포함

/**
 * 
 * 애니메이터 컨트롤러
 * 애니메이션 재생 제어: P누르면 재생, S누르면 Stop
 */
public class AnimController : MonoBehaviour
{
    public Animator animator; //여기에 애니메이터 컴포넌트 할당 (인스펙터에서 할당. 만약 동적 할당 원하면 start문에서)
    public Slider slider; //인스펙터에서 할당.
    
    void Start ()
    {
        //초기값 지정.
        slider.value = 0f;
        animator.speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            animator.speed = 1f;
            slider.value = animator.speed;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.speed = 0f;
            slider.value = animator.speed;
        }
    }

    
    public void OnSlider_SetValue()
    {
        animator.speed=slider.value;

    }
    
}
