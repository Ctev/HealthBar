using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Text _health;

    private void Update()
    {
        _health.text = _slider.value + " / " + _slider.maxValue;
    }
}
