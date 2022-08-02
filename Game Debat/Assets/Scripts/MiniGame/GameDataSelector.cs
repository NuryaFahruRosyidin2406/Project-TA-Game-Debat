using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataSelector : MonoBehaviour
{
    // get the current game data by refrencing it in Unity inspector
    public GameData currentGameData;
    public GameLevelData levelData;

    // Awake is called right after the sistem start
    void Awake()
    {
        SelectSequentalBoardData();
    }

    // Get the Board data
    private void SelectSequentalBoardData()
    {
        foreach (var data in levelData.data)
        {
            if (data.categoryName == currentGameData.selectedCategoryName)
            {
                // randomize the board data
                var boardIndex = Random.Range(0,5);
                Debug.Log("Puzzle yang di buka " + boardIndex);

                if (boardIndex < data.boardData.Count)
                {
                    currentGameData.selectedBoardData = data.boardData[boardIndex];
                }
                else
                {
                    var randomIndex = Random.Range(0, data.boardData.Count);
                    currentGameData.selectedBoardData = data.boardData[randomIndex];
                }
            }
        }
    }
}
