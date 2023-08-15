using UnityEngine;
using InstantGamesBridge;

public class DestroyMob: MonoBehaviour
{
    void Awake()
    {
        if (Bridge.device.type != InstantGamesBridge.Modules.Device.DeviceType.Desktop)
        {
            Destroy(gameObject);
        }
    }
}