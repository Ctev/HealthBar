using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Health _health;

    private float _duration;

    private void OnValidate()
    {
        _duration = 1.2f;
    }

    public void Add()
    {
        _slider.DOValue(_health.GetHeal(), _duration);
    }

    public void Decrease()
    {
        _slider.DOValue(_health.GetDamage(), _duration);
    }
}