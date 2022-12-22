using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Boss {
    // each stage of the boss inherits from this class
    public class BossStage : MonoBehaviour
    {
        [SerializeField] private BossStage _nextStage;

        protected void LoseStage(){
            // TODO play sound
            Managers.MinigamesManager.DeclareCurrentMinigameLost();
            Managers.MinigamesManager.EndCurrentMinigame(/*TODO add appropriate delay for lose animation*/);
        }

        protected void WinStage(){
            // TODO do scene transition
            // TODO play sound
            if(_nextStage == null){
                Managers.MinigamesManager.DeclareCurrentMinigameWon();
                Managers.MinigamesManager.EndCurrentMinigame(/*TODO add appropriate delay for win animation*/);
            }else{
                // TODO destroy this stage and load in _nextStage
            }
        }
    }
}