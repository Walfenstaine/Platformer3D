using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using pEventBus;
using UnityEngine;

public class Load : MonoBehaviour, IEventReceiver<OnLoadIsComplete>
{
    public Data data;
    
    public void OnEvent(OnLoadIsComplete e)
    {
        SceneManager.LoadScene(data.lvl);
    }

    void Start()
    {
        EventBus.Register(this);
        SaveAndLoad.Instance.Load();
    }

    private void OnDestroy()
    {
        EventBus.UnRegister(this);
    }
}
