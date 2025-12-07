using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [Header("Components")]
    public AudioSource mainAudioSource; 
    // Pause state
    private bool isManuallyPaused = false; 

    [Header("Ref UI Toggles")]
    public Toggle playPauseToggle; // Toggle Play/Pause
    public Toggle muteToggle;      // Toggle Mute/Unmute
    void Start()
    {
        // Check if AudioSource exists
        if (mainAudioSource == null)
            mainAudioSource = gameObject.AddComponent<AudioSource>();
            
        mainAudioSource.playOnAwake = false;
    }

    // Triggered by the checkpoint
    public void PlayNewTrack(AudioClip clip)
    {
        if (mainAudioSource.clip == clip && mainAudioSource.isPlaying) return;

        mainAudioSource.clip = clip;
        mainAudioSource.Play();
        isManuallyPaused = false;
        if (playPauseToggle != null)
        {
            // Set ON = Play
            playPauseToggle.SetIsOnWithoutNotify(true); 
        }

        if (muteToggle != null)
        {
            // Set OFF = Unmute
            muteToggle.SetIsOnWithoutNotify(false);
            mainAudioSource.mute = false; 
        }
    }

    // Buttons UI Panel-AudioController

    // Toggle Play/Pause (On Value Changed)
    public void TogglePlayPause(bool isPlay)
    {
        if (isPlay)
        {
            if (mainAudioSource.clip != null) mainAudioSource.Play();
            isManuallyPaused = false;
        }
        else
        {
            mainAudioSource.Pause();
            isManuallyPaused = true;
        }
    }

    // Button Restart (On Click)
    public void RestartTrack()
    {
        if (mainAudioSource.clip != null)
        {
            mainAudioSource.Stop();
            mainAudioSource.Play();
            // To be sure that Play Toggle is ON
            if (playPauseToggle != null) playPauseToggle.SetIsOnWithoutNotify(true);
            isManuallyPaused = false;
        }
    }

    // Toggle Mute (On Value Changed)
    public void ToggleMute(bool isMuted)
    {
        mainAudioSource.mute = isMuted;
    }
    
    // Optional Stop
    public void StopAudio()
    {
        mainAudioSource.Stop();
    }
}