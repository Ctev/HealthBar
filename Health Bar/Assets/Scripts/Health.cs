using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    // Health самосто€тельна€ сущность, никак не завис€ща€ от слайдера/бара.
    // ћетоды Heal и Damage не должны ничего возвращать. ѕри их вызове происходит
    // изменение здоровь€, проверка на мин макс и вызов ивента, сообщающего всем
    // об изменении здоровь€

    [SerializeField] private Slider _slider;
    [SerializeField] private Button _healButton;
    [SerializeField] private Button _damageButton;

    private float _currentHealth;
    private float _maxHealth;
    private float _duration;
    private float _receivedHealth;
    private float _lostHealth;

    private void OnValidate()
    {
        _maxHealth = _slider.maxValue;
        _duration = 1.2f;
        _receivedHealth = 10f;
        _lostHealth = 10f;
    }

    private void Start()
    {
        _healButton.onClick.AddListener(Heal);
        _damageButton.onClick.AddListener(Damage);
    }

    private void Update()
    {
        _slider.value = _currentHealth;
    }

    private void Heal()
    {
        //if (_currentHealth + receivedHealth > _maxHealth)
        //    _currentHealth = _maxHealth;
        //else
        //    _currentHealth += receivedHealth;

        _slider.DOValue(_currentHealth += _receivedHealth, _duration);
        //_currentHealth += _receivedHealth;

        //_slider.DOValue(_currentHealth, _duration);
    }

    private void Damage()
    {
        _slider.DOValue(_currentHealth -= _lostHealth, _duration);
        //_currentHealth -= _lostHealth;
    }
}