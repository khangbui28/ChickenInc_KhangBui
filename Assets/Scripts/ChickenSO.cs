using UnityEngine;

[CreateAssetMenu(fileName = "ChickenSO", menuName = ("Scriptable Objects/Chicken"))]
public class ChickenSO : ScriptableObject
{
    [SerializeField] private int health;
    [SerializeField] private int score;

    public int Health => health;
    public int Score => score;
}
