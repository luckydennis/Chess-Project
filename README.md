# Chess Web App Project


[Link to my Chess Web App](http://chessproject2.azurewebsites.net)


## About
I wanted to create a chess game in the console application using C# and then a web application. This will allow players to play against each other or play against a computer for practice. From this Chess App game I wanted to learn more about game development and web development.


## Requirements Test 
| ID   | Description              | Test Method   | Test Procedure                                     | Current Status | TimeStamp|
| ---- |:------------------------:| -------------:| :--------------------------------------------------| --------------:| --------:|
| 1.0  | Check Homepage           | Demonstration | The home button and link should display correctly. | Passing        | 5/2/2019 |
| 2.0  | Check Play button        | Demonstration | Click Play and check if chessboard plays correctly.| Passing        | 5/2/2019 |
| 3.0  | Check database button    | Demonstration | Click database and check if chessboard plays correctly.| Passing        | 5/2/2019 |
| 3.1  | edit the database        | Demonstration | edit the database and check for correct update | Passing        | 5/2/2019 |
| 3.2  | create an input          | Demonstration | click create and input a new input .| Passing        | 5/2/2019 |
| 3.3  | delete an input from database | Demonstration | delete an input and check the table| Passing        | 5/2/2019 |
| 4.0  | Register Authentication     | Demonstration | click register button and sucessfully create an account| Passing        | 5/14/2019 |
| 4.1  | Login using registered account | Demonstration| use a registered account and try logging in | Passing | 5/14/2019|
| 5.0  | Login needs to be done first | Demonstration | You need to be logged in first before to play, add data or chat| Failed | 5/14/2019 |
## In-Process Review
I started off thinking of creating a chess game in the console application using C#. I noticed that it was taking too much time to create a chess engine so I was able to find couple C# chess libraries(ProgramFOX/Chess.Net and rudzen/ChessLib). However, I was not able to use these libraries becasue my main goal was to create a web application and I was running into problems using C# code. After doing more searching I was able to find a javascript chess library. The engine I use is [chess.js](https://github.com/jhlywa/chess.js/) and the user interface is [chessboard.js](https://chessboardjs.com/). Currently, I was able to embed the game into my website, I am thinking of adding more features.

## Currently Working On
* Be able to auto save the game to the database rather than manually inputing the game information.
* Be able to load games using the Fen string.
* Store PGN data to see previous moves.
* Add some CSS to the website.
* Add actual user log in so I can use the user name(player).

## Future Implementation
* Player vs Computer
* Real time chess
* Clock
