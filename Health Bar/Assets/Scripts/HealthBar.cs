using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Text _healthPointsLabel;

    private void Update()
    {
        _healthPointsLabel.text = _slider.value + " / " + _slider.maxValue;
    }
}