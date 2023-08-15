using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    public Sprite soundIsOn, soundIsOff;
    public Data data;
    public AudioSource sorse;
    public Button butt;
    public Image im;

    private void Awake()
    {
       sorse.mute = !data.soundOn;
       SetSprite(data.soundOn);
    }

    private void SetSprite(bool stateTemp)
    {
        if (stateTemp)
        {
            im.sprite = soundIsOn;
        }
        else
        {
            im.sprite = soundIsOff;
        }
    }

    private void OnEnable()
    {
        butt.onClick.AddListener(Change);
    }

    private void OnDisable()
    {
        butt.onClick.RemoveListener(Change);
    }

    private void Change()
    {
        data.soundOn = !data.soundOn;
        SetSprite(data.soundOn);
        sorse.mute = !data.soundOn;
    }
}