using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer Video;

    // Start is called before the first frame update
    void Start()
    {
        Video.Play();
        Video.isLooping = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Video.Stop();
        }
        else
        {
            Video.Play();
        }
    }
}
