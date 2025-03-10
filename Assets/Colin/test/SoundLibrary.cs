// TEMPLATE 2: SOUND LIBRARY SCRIPTABLE OBJECT
// ==========================================
// Instructions: Fill in the missing code where indicated by TODO comments
using UnityEngine;

// TODO: Add the CreateAssetMenu attribute

public class SoundLibrary : MonoBehaviour
{
    // TODO: Create a serialized field for an array of AudioClips

    // TODO: Create an array of string names that correspond to each sound

    // Method to get a sound by name
    public AudioClip GetSound(string soundName)
    {
        // TODO: Find and return the audio clip that matches the provided name
        // Hint: Loop through the names array and return the clip at the same index

        Debug.LogWarning("Sound not found: " + soundName);
        return null;
    }

    // Method to get a sound by index
    public AudioClip GetSound(int index)
    {
        // TODO: Return the audio clip at the specified index (with bounds checking)

        return null;
    }
}

