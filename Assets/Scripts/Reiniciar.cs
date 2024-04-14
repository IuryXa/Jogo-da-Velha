using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetButtonDown("Fire1") && EventSystem.current.currentSelectedGameObject.name == "reiniciarJogo"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
