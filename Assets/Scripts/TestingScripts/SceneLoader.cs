using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.TestingScripts
{
    internal class SceneLoader : MonoBehaviour
    {

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                SceneManager.LoadSceneAsync("XSR_2", LoadSceneMode.Additive);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                SceneManager.LoadSceneAsync("XSR_3", LoadSceneMode.Additive);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                SceneManager.UnloadSceneAsync("XSR_2");
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                SceneManager.UnloadSceneAsync("XSR_3");
            }
        }
    }
}
