using UnityEngine;

[CreateAssetMenu(fileName = "Language", menuName = "ScriptableObjects/Language", order = 2)]
public class Language: ScriptableObject
{
    [field: TextArea(5,5)]
    [field: SerializeField] public string en {get; private set;}
    [field: TextArea(5, 5)]
    [field: SerializeField] public string ru {get; private set;}
}