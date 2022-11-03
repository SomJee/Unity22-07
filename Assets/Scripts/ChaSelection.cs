using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChaSelection : MonoBehaviour
{
    public int cha;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("Cha "+ cha.ToString());
    }
}
