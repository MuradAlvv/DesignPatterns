namespace DesignPatterns.Composite.InteractableObjects;

public class Door : IInteractable
{
    private bool _opened;

    private void ChangeState()
    {
        _opened = !(_opened);
    }

    public void Interact()
    {
        ChangeState();
    }
}