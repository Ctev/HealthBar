using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Text _healthPointsLabel;

    private float _currentHealth;
    private float _maxHealth;
    private float _receivedHealth;
    private float _lostHealth;

    private void OnValidate()
    {
        _maxHealth = _slider.maxValue;
        _receivedHealth = 10f;
        _lostHealth = 10f;
    }

    private void Update()
    {
        _currentHealth = _slider.value;
        _healthPointsLabel.text = _currentHealth + " - " + _maxHealth;
    }

    public float GetHeal()
    {
        return _currentHealth += _receivedHealth;
    }

    public float GetDamage()
    {
        return _currentHealth -= _lostHealth;
    }
}