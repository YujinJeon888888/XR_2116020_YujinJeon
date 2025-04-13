using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController: MonoBehaviour
{
    public AudioSource[] Audio;
    void Start()
    {
        Audio[0].loop = true;
        Audio[0].Play();
        if (Audio.Length > 1)
        {
            Audio[1].loop = true;
            Audio[1].Play();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            for (int i = 0; i < Audio.Length; i++)
            {
                if (Audio[i].isPlaying)
                {
                    Audio[i].Pause();
                }
                else
                {
                    Audio[i].Play();
                }
            }
        }
    }

}
