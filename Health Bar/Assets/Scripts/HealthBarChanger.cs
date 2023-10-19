using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBarChanger : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private float _duration;
    private int _receivedHealth;
    private int _lostHealth;

    private void OnValidate()
    {
        _duration = 1.2f;
        _receivedHealth = 10;
        _lostHealth = 10;
    }

    public void Add()
    {
        _slider.DOValue(_slider.value + _receivedHealth, _duration);
    }

    public void Decrease()
    {
        _slider.DOValue(_slider.value - _lostHealth, _duration);
    }
}