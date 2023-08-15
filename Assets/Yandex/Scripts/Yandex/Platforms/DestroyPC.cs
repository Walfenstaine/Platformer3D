using UnityEngine;
using InstantGamesBridge;

public class DestroyPC: MonoBehaviour
{

    void Awake()
    {
        if (Bridge.device.type == InstantGamesBridge.Modules.Device.DeviceType.Desktop)
        {
            Destroy(gameObject);
        }
    }
}