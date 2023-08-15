using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Data", order = 1)]
public class Data: ScriptableObject
{
    public int record;
    public int up;
    public string lvl;
    public float sense = 0.5f;
    public bool soundOn;
}
