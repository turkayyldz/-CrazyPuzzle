using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPanel : MonoBehaviour
{
   public static MenuPanel Instance { get; private set; }
   public GameObject[] panel;
    
    private void Awake()
    {
        
        if (Instance == null)
        {
            Instance = this;
            //sahneler arasi gecis yapmamiza yariyor.
            //DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
        
    }
   
    public void Winn(int index)
    {
        panel[index].SetActive(true);
       
    }
    
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
  
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void Level2()
    {
        SceneManager.LoadScene(1);
    }
    public void Level3()
    {
        SceneManager.LoadScene(2);
    }
    public void Level4()
    {
        SceneManager.LoadScene(3);
    }
    public void Level5()
    {
        SceneManager.LoadScene(4);
    }
}
