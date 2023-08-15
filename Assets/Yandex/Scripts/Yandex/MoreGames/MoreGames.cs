using UnityEngine;
using UnityEngine.UI;
using InstantGamesBridge;

public class OpenUrl : MonoBehaviour
{
    public Language urlRu;
    public Language urlCom;


    private Button butt;
    private Language urlTemp;

    void Awake()
    {
        butt = GetComponent<Button>();
        if (Bridge.platform.domen == "ru")
        {
            urlTemp = urlRu;
        }
        else
        {
            urlTemp = urlCom;
        }
    }

    void OnEnable()
    {
        butt.onClick.AddListener(Open);
    }

    void OnDisable()
    {
        butt.onClick.RemoveListener(Open);
    }

    void Open()
    {
        if (Bridge.platform.language == "ru")
        {
            Application.OpenURL(urlTemp.ru);
        }
        else
        {
            Application.OpenURL(urlTemp.en);
        }
    }


}