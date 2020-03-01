using System.Collections;
using System.Collections.Generic;
//using UnityEditor.SceneManagement;
//using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

//using UnityEngine.SceneManagement;


/// <summary>
/// This class handles a click on the "Send Message" button in the "It's a Match" message.
/// </summary>

public class OpenMessagesBehavior : MonoBehaviour {

	/// <summary>
	/// The messageController variable will be needed to call a method from MessageController script.
	/// </summary>

	private MessageController messageController;

	public GameObject current_page;

	public GameObject messenger;
	
	/// <summary>
	/// OuMouseDown handles the click on "Send Message" during the "It's a Match!" message.
	/// This script will find MessageController, assign it to messageController, call the method "OpenMessages ()" using a reference to the script assigned previously 
	/// which will then disable the main area and enable the message area of the game.
	/// </summary>

	void OnMouseDown (){
		messageController = FindObjectOfType (typeof (MessageController)) as MessageController;
		messenger.SetActive(true);
		current_page.SetActive(false);

//		messageController.OpenMessages ();
//		SceneManager.LoadScene("Messenger", LoadSceneMode.Additive);
//		this.OnDestroy();
//		Scene s = EditorSceneManager.GetSceneByName("main");
//		
//		EditorSceneManager.CloseScene(s, true);

	}
	void OnDestroy()
	{
		

		Debug.Log("OnDestroy1");
	}
}
