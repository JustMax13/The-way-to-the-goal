using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateButton : MonoBehaviour
{
    [SerializeField] private TrackedButton _trackedButton;
    [SerializeField] private Part _part;

    [SerializeField] private int _rotationSpeed;

    private bool _buttonHeld;

    public Part Part { get => _part; set => _part = value; }

    private void Awake()
    {
        _trackedButton.IsOnPointerDown += OnPointerDown;
        _trackedButton.IsOnPointerUp += OnPointerUp;
    }
    private void Update()
    {
        if (_buttonHeld)
            Rotate();
    }

    private void OnPointerDown()
        => SetButtonHeld(true);
    private void OnPointerUp()
        => SetButtonHeld(false);

    public void SetButtonHeld(bool value)
        => _buttonHeld = value;
    public void SetPartToRotate(int partIndex, Side side)
    {
        switch (side)
        {
            case Side.Left:
                {
                    _part = PartValues.LeftParts[partIndex];
                    break;
                }
            case Side.Right:
                {
                    _part = PartValues.RightParts[partIndex];
                    break;
                }
            default:
                {
                    Debug.LogWarning("Некоректно вказана сторона частини");
                    break;
                }
        }
    }
    public void Rotate() 
        => RotatePart.Rotate(_part, _rotationSpeed);
}
