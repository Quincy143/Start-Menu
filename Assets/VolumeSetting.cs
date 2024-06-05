using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSetting : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider musicSlider;

    public void setMusicVolume()
    {
        float volume = musicSlider.value;
        myMixer.SetFloat("StartingMenuMusic", Mathf.Log10(volume)*20);
    }
}
