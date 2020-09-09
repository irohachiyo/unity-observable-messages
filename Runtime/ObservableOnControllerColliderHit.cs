using UnityEngine;

public class ObservableOnControllerColliderHit : MonoBehaviour
{
    public delegate void EventHandler(ControllerColliderHit hit);

    private event EventHandler onEvent;

    public event EventHandler OnEvent
    {
        add => onEvent += value;
        remove => onEvent -= value;
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        onEvent?.Invoke(hit);
    }
}
