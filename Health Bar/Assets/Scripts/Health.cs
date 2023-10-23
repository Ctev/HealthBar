using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private float _currentHealth;
    private float _maxHealth;

    private void Update()
    {
        _currentHealth = _slider.value;
        _maxHealth = _slider.maxValue;
    }

    public float Heal(float receivedHealth)
    {
        return _currentHealth += receivedHealth;
    }

    public float Damage(float lostHealth)
    {
        return _currentHealth -= lostHealth;
    }
}