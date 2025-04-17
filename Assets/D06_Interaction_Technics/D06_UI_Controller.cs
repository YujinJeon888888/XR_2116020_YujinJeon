using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class D06_UI_Controller : MonoBehaviour
{
    public TMP_Text PickCounts;             // Step04
    public TMP_Text PutCounts;              // Step05


    public void Display_PickCounts(int count)
    {
        PickCounts.text = count.ToString();
    }

    public void Display_PutCounts()
    {
        int lastPutCount = int.Parse(PutCounts.text);
        int currentPutCount = lastPutCount + 1;
        PutCounts.text = currentPutCount.ToString();
    }

    public void Decrease_PickCounts()
    {
        //UI에 값이 저장되어있으므로, 그 값을 읽어옴. //Parse : (text값을 정수로 바꿈)
        int lastPickCount = int.Parse(PickCounts.text);
        //감소
        int currentPickCount = lastPickCount - 1;
        //감소된 값으로 UI 업데이트
        PickCounts.text = currentPickCount.ToString();
    }

    /// <summary>
    /// PickCount변수값을 리턴
    /// </summary>
    /// <returns>
    /// PickCount 를 리턴.
    /// </returns>
    public int GetPickCounts()
    {
        int pickCounts = int.Parse(PickCounts.text);
        return pickCounts;
    }
}
