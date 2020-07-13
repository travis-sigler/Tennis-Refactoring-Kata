# Tennis Refactoring Kata

There are three versions of this refactoring kata, each with their own design smells and challenges. We suggest you start with the first one, with the class "TennisGame1". The test suite provided is fairly comprehensive, and fast to run. You should not need to change the tests, only run them often as you refactor.

## Goal
The aim of this Kata is to refactor the code into a state that you would be happy leaving for your peers (or your future self!) to work on.

## Considerations

* We're looking for incremental improvements, so commit as often as you can. 
* Use the tests to provide feedback on your changes.
* Ask yourself:
  * Is the code readable?
  * Does the code express intent well?
  * Is there any obscure logic that could be simplified?

## Scope

We're only looking for refactorings here. The overall behaviour of the code should not change. However, you are permitted to change the public interface if you deem it necessary.

You need only report the score for the current game. Sets and Matches are out of scope.

## Tennis Kata

Tennis has a rather quirky scoring system, and to newcomers it can be a little difficult to keep track of. The tennis society has contracted you to build a scoreboard to display the current score during tennis games. 

Your task is to write a “TennisGame” class containing the logic which outputs the correct score as a string for display on the scoreboard. When a player scores a point, it triggers a method to be called on your class letting you know who scored the point. Later, you will get a call “score()” from the scoreboard asking what it should display. This method should return a string with the current score.

You can read more about Tennis scores [here](http://en.wikipedia.org/wiki/Tennis#Scoring) which is summarized below:

1. A game is won by the first player to have won at least four points in total and at least two points more than the opponent.
2. The running score of each game is described in a manner peculiar to tennis: scores from zero to three points are described as "Love", "Fifteen", "Thirty", and "Forty" respectively.
3. If at least three points have been scored by each player, and the scores are equal, the score is "Deuce".
4. If at least three points have been scored by each side and a player has one more point than his opponent, the score of the game is "Advantage" for the player in the lead.