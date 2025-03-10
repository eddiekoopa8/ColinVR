using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

using Random = UnityEngine.Random;

public class AudioLib : MonoBehaviour
{
    public AudioSource SoundObject;
    private void PlayFX_(AudioClip clip, Vector3 pos, float volume)
    {
        AudioSource src = Instantiate(SoundObject, pos, Quaternion.identity);
        src.clip = clip;
        src.volume = volume;
        src.Play();

        float t = src.clip.length;
        Destroy(src.gameObject, t);
    }

    /**
     * =================
     *  STATIC WRAPPERS
     * =================
     */
    private static AudioLib __smINST;
    public static AudioLib GetInstance()
    {
        return __smINST;
    }

    public static void PlayFX(AudioClip clip, Vector3 pos, float volume)
    {
        GetInstance().PlayFX_(clip, pos, volume);
    }
    public static void PlayFX(AudioClip clip, Vector3 pos)
    {
        PlayFX(clip, pos, 1f);
    }
    
    public static void PlayFXRandom(AudioClip[] clips, Vector3 pos, float volume)
    {
        int idx = Convert.ToInt32(Random.Range(0, clips.Length));
        GetInstance().PlayFX_(clips[idx], pos, volume);
    }
    public static void PlayFXRandom(AudioClip[] clips, Vector3 pos)
    {
        PlayFXRandom(clips, pos, 1f);
    }
}
