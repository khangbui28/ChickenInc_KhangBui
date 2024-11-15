using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public static event UnityAction<int> OnAddPoints;

    public static void RaiseAddPoints(int points) => OnAddPoints?.Invoke(points);
}
