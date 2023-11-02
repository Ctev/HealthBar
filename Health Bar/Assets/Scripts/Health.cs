using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Button _healButton;
    [SerializeField] private Button _damageButton;

    private float _currentHealth;
    private float _targetHealth;
    private float _maxHealth;
    private float _updateSpeed;
    private float _receivedHealth;
    private float _lostHealth;

    private void OnValidate()
    {
        _maxHealth = _slider.maxValue;
        _updateSpeed = 10f;
        _receivedHealth = 10f;
        _lostHealth = 10f;
    }

    private void Start()
    {
        _healButton.onClick.AddListener(Heal);
        _damageButton.onClick.AddListener(Damage);
    }

    private IEnumerator UpdatingHealth()
    {
        while (_currentHealth != _targetHealth)
        {
            _currentHealth = Mathf.MoveTowards(_currentHealth, _targetHealth, _updateSpeed * Time.deltaTime);

            _slider.value = _currentHealth;

            yield return null;
        }
    }

    private void Heal()
    {
        if (_targetHealth < _maxHealth)
            _targetHealth += _receivedHealth;

        StartCoroutine(UpdatingHealth());
        StopCoroutine(UpdatingHealth());
    }

    private void Damage()
    {
        if (_targetHealth != 0)
            _targetHealth -= _lostHealth;

        StartCoroutine(UpdatingHealth());
        StopCoroutine(UpdatingHealth());
    }
}