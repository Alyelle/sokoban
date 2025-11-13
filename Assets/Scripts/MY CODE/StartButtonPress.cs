using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButtonPress : MonoBehaviour
{

    public Button butt;
    void Start()
    {
        butt.onClick.AddListener(OnButtonClick);
    }
    void OnButtonClick()
    {
        SceneManager.LoadScene("Level1");
    }
}
