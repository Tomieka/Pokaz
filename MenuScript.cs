using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volumeSlider;

    private bool isSoundOn = true;

    void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("Volume", 1.0f);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("PoziomGry");
    }

    public void Options()
    {
        isSoundOn = !isSoundOn;
        UpdateSound();
    }

    private void UpdateSound()
    {
        if (isSoundOn)
        {
            audioMixer.SetFloat("Volume", 0.0f);
        }
        else
        {
            audioMixer.SetFloat("Volume", -80.0f);
        }
    }

    public void AdjustVolume(float volume)
    {
        audioMixer.SetFloat("Volume", Mathf.Log10(volume) * 20); //20
        PlayerPrefs.SetFloat("Volume", volume);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}


//TODO