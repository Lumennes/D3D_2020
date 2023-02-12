using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DebugRestarter : MonoBehaviour
{
    bool m;
    void OnRestart()
    {
        GetComponent<CombatScript>().CancelInvoke(nameof(CombatScript.AutoBattle));

        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }
}
