using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{


    [SerializeField] public LevelManager level;

    private bool pressed;

    void Start ()
    {
        pressed = false;
    }
    public void OnTriggerEnter(Collider col)
    {
        //Debug.Log("not pressed");
        if (col.CompareTag("block"))
        {
            if (!pressed) { 
                level.buttonsPressed++;
                pressed = true;
                Debug.Log("pressed");
            }
            
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("block"))
        {
            if (pressed)
            {
                level.buttonsPressed--;
                pressed = false;    
                Debug.Log("not pressed");
            }
        }
    }
}
