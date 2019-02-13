using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class oyunkontrol : MonoBehaviour {
    public GameObject astroid;

    public Vector3 randompos;
    int score;
    public int bitisskor;
    public Text text;
    GameObject restart;
    GameObject quit;

	void Start ()
    {
        StartCoroutine(olustur());
        score = 0;
        text.text = "score=" + score;

        restart = GameObject.Find("restart");
        quit = GameObject.Find("quit");
        restart.SetActive(false);
        quit.SetActive(false);

	}
	    
	
	   IEnumerator olustur () {
        yield return new WaitForSeconds(1);
        while (true)
           {
            for (int i = 0; i < 10; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randompos.x, randompos.x), 0, randompos.z);
                Instantiate(astroid, vec, Quaternion.identity);
                yield return new WaitForSeconds(1); //bekleme suresi.Her bir saniyede bir astroid uretiyor.

            }
            yield return new WaitForSeconds(2);
            }
	   }
    

      public void scorearttir(int gelenscore)
    {
        score += gelenscore;
        text.text = "score=" + score;
        if(score==bitisskor)
        {
            restart.SetActive(true);
            quit.SetActive(true);
            Time.timeScale = 0;

        }

    }
  public void oyuntekrarla()
    {
        SceneManager.LoadScene("space");
        Time.timeScale = 1;
    }
public void oyuncıkıs()
    {
        Application.Quit();
    }
}
