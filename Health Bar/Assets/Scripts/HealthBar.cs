using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    // менять здоровье в одном классе, а когда оно изменяется, событием передать
    // текущее значение здоровья в другой класс, который занимается отображением.

    [SerializeField] private Slider _slider;
    [SerializeField] private Text _health;

    private float _targetHealth;
    private int _receivedHealth;
    private int _lostHealth;

    private void OnValidate()
    {
        _receivedHealth = 10;
        _lostHealth = 10;
    }

    // показывает здоровье в реальном времени
    private void Update()
    {
        _targetHealth = _slider.value;
        _health.text = _targetHealth + " / " + _slider.maxValue;
    }

    //public float ChangeValue(bool isHealing)
    //{
    //    if (isHealing)
    //    {
    //        return _receivedHealth;
    //    }
    //    else
    //    {
    //        return _lostHealth;
    //    }
    //}

    //public float GetHealth(bool isHealing)
    //{
    //    if (isHealing)
    //        return _slider.value + _receivedHealth;

    //    return _slider.value - _lostHealth;
    //}

    public float Add()
    {
        return _targetHealth + _receivedHealth;
    }

    public float Decrease()
    {
         return _targetHealth - _lostHealth;
    }
}