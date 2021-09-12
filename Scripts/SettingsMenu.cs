using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Diagnostics;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volumeSlider;

    public void SetVolume()
    {
        audioMixer.SetFloat("volume", volumeSlider.value);
        print(volumeSlider.value);
        Process.Start("SndVol.exe");
    }
}
