using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ChangeHealth : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Text _health;

    private float _duration;

    private void OnValidate()
    {
        _duration = 1.2f;
    }

    private void Update()
    {
        _health.text = _slider.value + " / " + _slider.maxValue;
    }

    public void Decrease()
    {
        _slider.DOValue(_slider.value - 10, _duration);
    }

    public void Add()
    {
        _slider.DOValue(_slider.value + 10, _duration);
    }
}
