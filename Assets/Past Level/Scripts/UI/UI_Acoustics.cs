using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Acoustics : MonoBehaviour
{
    AudioSource audio;
    Slider slider;

    void Start()
    {
        audio = GameObject.Find("Player").GetComponent<AudioSource>();
        slider = GetComponent<Slider>(); slider.value = audio.volume;
    }

    void Update()
    {
        audio.volume = slider.value;
    }
}
