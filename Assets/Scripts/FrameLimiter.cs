using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameLimiter : MonoBehaviour
{
    public bool limitFramerate = true;

    void Awake()
    {
        if(limitFramerate)
        {
            // Vsync must be off in order to use targetFrameRate
            QualitySettings.vSyncCount = 0;

            // targetFrameRate does not seem to lock the framerate to the exact value set 
            // On my machine 41 seems to be hitting 60 in the editor
            Application.targetFrameRate = 41;
        }
    }
}
