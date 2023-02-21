using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.Rendering.PostProcessing;
using UnityEngine.Rendering.Universal;

public class CameraManager : MonoBehaviour
{
    UniversalAdditionalCameraData uacd;
    
    int oldWidth = 638;
    int oldHeight = 460;

    // Start is called before the first frame update
    void Start()
    {
        uacd = GetComponent<UniversalAdditionalCameraData>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                QualitySettings.SetQualityLevel(0);
                uacd.antialiasing = AntialiasingMode.None;
                uacd.renderPostProcessing = false;
                uacd.renderShadows = false;
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                QualitySettings.SetQualityLevel(1);
                uacd.antialiasing = AntialiasingMode.None;
                uacd.renderPostProcessing = true;
                uacd.renderShadows = false;
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                QualitySettings.SetQualityLevel(2);
                uacd.antialiasing = AntialiasingMode.FastApproximateAntialiasing;
                uacd.renderPostProcessing = true;
                uacd.renderShadows = true;
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                QualitySettings.SetQualityLevel(3);
                uacd.antialiasing = AntialiasingMode.SubpixelMorphologicalAntiAliasing;
                uacd.antialiasingQuality = AntialiasingQuality.Low;
                uacd.renderPostProcessing = true;
                uacd.renderShadows = true;
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                QualitySettings.SetQualityLevel(4);
                uacd.antialiasing = AntialiasingMode.SubpixelMorphologicalAntiAliasing;
                uacd.antialiasingQuality = AntialiasingQuality.Medium;
                uacd.renderPostProcessing = true;
                uacd.renderShadows = true;
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                QualitySettings.SetQualityLevel(5);
                uacd.antialiasing = AntialiasingMode.SubpixelMorphologicalAntiAliasing;
                uacd.antialiasingQuality = AntialiasingQuality.High;
                uacd.renderPostProcessing = true;
                uacd.renderShadows = true;
            }

            if (Input.GetKeyDown(KeyCode.P))
            {
                // if (!postProcessVolume)
                //     postProcessVolume = GetComponent<PostProcessVolume>();
                // if (postProcessVolume)
                //     postProcessVolume.enabled = !postProcessVolume.enabled;

                uacd.renderPostProcessing = !uacd.renderPostProcessing;
            }

            if (Input.GetKeyDown(KeyCode.F11))
            {
                if (Screen.fullScreen)
                {
                    Screen.SetResolution(oldWidth, oldHeight, false);
                }
                else
                {
                    oldWidth = Screen.width;
                    oldHeight = Screen.height;
                    var width = Screen.mainWindowDisplayInfo.width;
                    var height = Screen.mainWindowDisplayInfo.height;
                    Screen.SetResolution(width, height, true);
                }
            }
    }
}
