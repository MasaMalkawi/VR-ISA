using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip uiButtonClickSFX;
    private AudioSource _audioSource;

    private void Awake() 
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void OnClickPlaySFX()
    {
        _audioSource.PlayOneShot(uiButtonClickSFX);
    }
}
