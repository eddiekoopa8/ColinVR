// SOUND PLAYER THAT USES THE SOUND LIBRARY
// ==========================================
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    // TODO: Add a serialized field for the SoundLibrary

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // TODO: Add an AudioSource component if one doesn't exist
        }
    }

    public void PlaySound(string soundName)
    {
        // TODO: Get the AudioClip from the SoundLibrary and play it
    }

    // Test function to play different sounds
    public void PlayJumpSound()
    {
        // TODO: Call PlaySound with the appropriate sound name
    }

    public void PlayCollectSound()
    {
        // TODO: Call PlaySound with the appropriate sound name
    }
}
