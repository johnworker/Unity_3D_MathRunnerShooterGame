using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public AudioSource backgroundMusic;
    public AudioSource shootSound;
    public AudioSource enemyDeathSound;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayShootSound()
    {
        shootSound.Play();
    }

    public void PlayEnemyDeathSound()
    {
        enemyDeathSound.Play();
    }
}
