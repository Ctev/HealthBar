using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBarChanger : MonoBehaviour
{
    // И вот уже второй класс будет заниматься перемещением слайдера до нового значения

    [SerializeField] private HealthBar _healthBar;
    [SerializeField] private Slider _slider;

    private float _duration;

    private void OnValidate()
    {
        //_healthBar = new HealthBar();
        _duration = 1.2f;
    }

    public void Heal()
    {
        _slider.DOValue(_healthBar.Add(), _duration);
    }

    public void Damage()
    {
        _slider.DOValue(_healthBar.Decrease(), _duration);
    }

    //public void Decrease()
    //{
    //    _slider.DOValue(_healthBar.GetHealth(false), _duration);
    //}
}