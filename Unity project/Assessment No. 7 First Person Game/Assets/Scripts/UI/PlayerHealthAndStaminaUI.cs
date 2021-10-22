using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthAndStaminaUI : MonoBehaviour
{

    public FloatObject Value;
    Slider UIElement;

    private void Awake()
    {
        UIElement = gameObject.GetComponent<Slider>();
        Value.value = 1f;
        UIElement.value = Value.value;
    }

    private void Update()
    {
        if (UIElement != null)
        {
            if (UIElement.value != Value.value)
            {
                if (Value.value > 1f)
                {
                    Value.value = 1f;
                    UIElement.value = Value.value;
                }
                if (Value.value < 0f)
                {
                    Value.value = 0f;
                    UIElement.value = Value.value;
                }

            }
        }
    }
}
