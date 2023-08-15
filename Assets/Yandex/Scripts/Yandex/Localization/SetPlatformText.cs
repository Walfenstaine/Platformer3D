using UnityEngine;
using UnityEngine.UI;
using InstantGamesBridge;

public class SetPlatformText : MonoBehaviour
{
    [SerializeField] private Language pC;
    [SerializeField] private Language mob;

    private Language language;

    private void Start()
    {

        if (Bridge.device.type == InstantGamesBridge.Modules.Device.DeviceType.Desktop)
        {
            language = pC;
        }
        else
        {
            language = mob;
        }

        Text myText = GetComponent<Text>();
        if (Bridge.platform.language == "ru")
        {
            myText.text = language.ru;
        }
        else
        {
            myText.text = language.en;
        }
    }
}
