using UnityEngine;

public class ChoosePartButton : MonoBehaviour
{
    [SerializeField] private int _partIndex;
    [SerializeField] private Side _side;

    public void SetPartToRotate()
    {
        switch (_side)
        {
            case Side.Left:
                {
                    foreach (var rotationButton in RotateButtonValues.LeftRotateButtons)
                        rotationButton.SetPartToRotate(_partIndex, _side);
                    break;
                }
            case Side.Right:
                {
                    foreach (var rotationButton in RotateButtonValues.RightRotateButtons)
                        rotationButton.SetPartToRotate(_partIndex, _side);
                    break;
                }
            default:
                Debug.LogWarning("Некоректно вказана сторона частини");
                break;
        }
    }
}
