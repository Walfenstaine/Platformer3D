using UnityEngine;
using UnityEngine.UI;
using InstantGamesBridge;

public class SetText: MonoBehaviour
{
    [SerializeField] private Language language;

    private void Start()
    {
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
