# Chess Console #
Chess game using C# in console


## Description
The project consists of two subprojects:
- Сhess - a class library describing the rules for moving chess pieces during a chess game;
- DemoChess - implementation of a chess game in the console.


## Сlasses 
Chess includes the following classes:
- Board - describes working with a chessboard. It uses Forsyth–Edwards Notation to determine the position of the pieces on the board;
- Square - describes struct squares of the chessboard;
- Figure - Enum figures on the chessboard;
- FigureMoving - describes the movement of pieces on the board;
- Moves - describes chess rules;
- Chess - main class describing a chess game.

DemoChess implements a chess game in console.
The program demonstrates FEN of the current move, chess board and list of possible moves.