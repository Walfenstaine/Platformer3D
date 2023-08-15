using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using pEventBus;

public class ButtonShowInter: MonoBehaviour
{
    public void Show()
    {
        EventBus<ShowInterAds>.Raise(new ShowInterAds()
        {

        });
    }
}
