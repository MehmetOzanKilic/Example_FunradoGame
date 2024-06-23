using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource soundEffectSource;
    public AudioClip grapeAudioClip;

    public AudioClip buzzAudioClip;

    void Start()
    {
        PlaySoundEffect();
    }

    public void PlaySoundEffect()
    {
        if (soundEffectSource != null && grapeAudioClip != null)
        {
            soundEffectSource.clip = grapeAudioClip;

            soundEffectSource.Play();
        }
    }

    public void PlayBuzzEffect()
    {
        if (soundEffectSource != null && buzzAudioClip != null)
        {
            soundEffectSource.clip = buzzAudioClip;

            soundEffectSource.Play();
        }
    }
}
