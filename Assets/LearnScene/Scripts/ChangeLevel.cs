using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//please explain the code with comment
public class ChangeLevel : MonoBehaviour
{
   public void ChangeScene(string levelName)
   {
        SceneManager.LoadScene(levelName);
   }
}
