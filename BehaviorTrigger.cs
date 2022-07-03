
using UnityEngine;
using UnityEngine.Events;

public class BehaviorTrigger : MonoBehaviour
{
    public UnityEvent BehaviorEvent;

    private void OnTriggerEvent(Collider other)
    {
        BehaviorEvent.Invoke();
    }

}
