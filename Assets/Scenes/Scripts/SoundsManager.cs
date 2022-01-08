using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundsManager : MonoBehaviour
{
    [SerializeField] Image off;
    [SerializeField] Image on;
    private bool Mute;

    void Start()
    {
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }

        else { Load(); }

        UpdateButtonIcon();
        AudioListener.pause = Mute;
    }

    // Update is called once per frame
    public void OnButtonPress()
    {
        if (Mute == false)
        {
            Mute = true;
            AudioListener.pause = true;
        }

        else
        {
            Mute = false;
            AudioListener.pause = false;
        }

        Save();
        UpdateButtonIcon();
    }

    private void UpdateButtonIcon()
    {
        if (Mute == false)
        {
            on.enabled = true;
            off.enabled = false;
        }

        if (Mute == true)
        {
            on.enabled = false;
            off.enabled = true;
        }
    }

    private void Load()
    {
        Mute = PlayerPrefs.GetInt("muted") == 1;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("muted", Mute ? 1 : 0);
    }
}
