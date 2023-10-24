using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    //[SerializeField] private Health _health;
    [SerializeField] private Text _healthPointsLabel;

    //private float _duration;
    //private float _receivedHealth;
    //private float _lostHealth;

    //private void OnValidate()
    //{
    //    _duration = 1.2f;
    //    _receivedHealth = 10f;
    //    _lostHealth = 10f;
    //}

    private void Update()
    {
        _healthPointsLabel.text = _slider.value + " / " + _slider.maxValue;
    }
}