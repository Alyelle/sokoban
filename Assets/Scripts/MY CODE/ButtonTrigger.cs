using UnityEngine;

public class ButtonTrigger
{
    public void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("block"))
        {
            return;
        }
        return;
    }
}
