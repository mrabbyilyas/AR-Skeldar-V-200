
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewSceneManager : MonoBehaviour
{
    public Animator anim;

	private int SceneToLoad;
    private int SceneCurrent;

    public AudioSource audioSource;
    public AudioClip Back_SFX, quit_SFX;
	
	// Update is called once per frame
	void Update () {
        SceneCurrent = SceneManager.GetActiveScene().buildIndex;
		if(SceneCurrent == 0){
            if (Input.GetKeyDown(KeyCode.Escape)){
                audioSource.clip = quit_SFX;
                audioSource.Play();
                anim.SetTrigger("FadeOut");
                Application.Quit();
                Debug.Log("berhasil Quit Application");
            }
        }
        else if(SceneCurrent == 1)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                audioSource.clip = Back_SFX;
                audioSource.Play();
                FadeToScene(0);
            }
        }
        
	}

	public void FadeToScene (int SceneIndex)
	{
        if(SceneIndex == -1){
            audioSource.clip = quit_SFX;
            audioSource.Play();
            Application.Quit();
            Debug.Log("berhasil Quit Application");
        } else {
            SceneToLoad = SceneIndex;
        }

		anim.SetTrigger("FadeOut");
	}

	public void OnFadeComplete ()
	{
		SceneManager.LoadScene(SceneToLoad);
	}
    
}
