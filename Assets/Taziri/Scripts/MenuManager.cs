using System;
using Fungus;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Taziri.Scripts {
    public class MenuManager : MonoBehaviour {
        // private GameState currentGameState;
        private LanguageManager languageManager;
        [SerializeField] private GameObject mainMenu;
        [SerializeField] private GameObject finishMenu_English;
        [SerializeField] private GameObject finishMenu_Hindi;
        // [SerializeField] private GameObject pauseMenu_English;
        // [SerializeField] private GameObject pauseMenu_Hindi;
        // [SerializeField] private GameObject HUD_English;
        // [SerializeField] private GameObject HUD_Hindi;

        private void Start() {
            // currentGameState = GameState.Playing;
            languageManager = GetComponent<LanguageManager>();
        }

        public void StartGame() {
            mainMenu.SetActive(false);
            /*switch (languageManager.getSelectedLanguage()) {
                case "English":
                    HUD_English.SetActive(true);
                    break;
                case "Hindi":
                    HUD_Hindi.SetActive(true);
                    break;
            }*/
        }

        public void DisplayFinishMenu_English() {
            finishMenu_English.SetActive(true);
        }
        public void DisplayFinishMenu_Hindi() {
            finishMenu_Hindi.SetActive(true);
        }

        /*public void Pause() {
            currentGameState = currentGameState == GameState.Playing ? GameState.Paused : GameState.Playing;
            
            switch (languageManager.getSelectedLanguage()) {
                case "English":
                    HUD_English.SetActive(currentGameState == GameState.Playing);
                    pauseMenu_English.SetActive(currentGameState == GameState.Paused);
            break;
                case "Hindi":
                    HUD_Hindi.SetActive(currentGameState == GameState.Playing);
                    pauseMenu_Hindi.SetActive(currentGameState == GameState.Paused);
                    break;
            }
        }*/
        
        public void Restart() {
            SceneManager.LoadScene(0);
        }
        public void Quite() {
            Application.Quit();
        }
    }
}