using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class AudioScripts : MonoBehaviour
{
    public AudioMixer audioMixer;
    string _mixerChanelToEdit;

    public void GetCurrentMixer(string name)
    {
        _mixerChanelToEdit = name;
    }
    public void ChangeVolume(float volume)
    {
        audioMixer.SetFloat(_mixerChanelToEdit, volume);
    }
}
