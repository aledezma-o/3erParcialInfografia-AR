using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
	void Start()
	{
		print("reiniciamos");
	}

	public void ResetScene()
    {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
