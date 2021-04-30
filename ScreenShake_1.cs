using System.Collections;
using UnityEngine;
using Cinemachine;

//Easy Screenshake for Cinemachine. Attach this to a Game Object in the scene
//In the editor click on your VirtualCamera. Select Noise: "Basic Multi Channel Perlin" & pick a profile
//syntax ( StartCoroutine(screenShakeScriptRef.ShakeVCam(vCamIWantToShake, .2f, 50f, .15f)); )
public class ScreenShake_1 : MonoBehaviour
{

    //Shake it like a polaroid pick cha
    public IEnumerator ShakeVCam(CinemachineVirtualCamera vCam, float amp, float freq, float duration)
    {
        CinemachineBasicMultiChannelPerlin noise = vCam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        noise.m_AmplitudeGain = amp;
        noise.m_FrequencyGain = freq;
        yield return new WaitForSeconds(duration);
        noise.m_AmplitudeGain = 0;
    }
}